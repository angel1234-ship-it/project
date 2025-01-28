using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo, edId, stock, FarmerId, agencyId, agency,flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {
                DataList();
                MultiView1.ActiveViewIndex = 0;
                DetailsView();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
     
           

        
           
        }
    }
    protected void DataList()
    {
        IdNo = Convert.ToInt32(Session["farmerpid"].ToString());

       
        string selQry = "select * from tbl_farmerproduct f inner join tbl_category c on f.category_id=c.category_id where f.farmerproduct_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvpineapplemore.DataSource = dt;
        dvpineapplemore.DataBind();
    }





    protected void dvpineapplemore_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {

        if (e.CommandName == "buy")
        {
            Session["farmerpid"] = e.CommandArgument.ToString();
            //MultiView1.ActiveViewIndex = 1;
            IdNo = Convert.ToInt32(Session["farmerpid"].ToString());
            string selQry = "select farmerproduct_stock,farmerproduct_price from tbl_farmerproduct where farmerproduct_id='" + IdNo + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtquantity.Text = dt.Rows[0]["farmerproduct_stock"].ToString();
            txtprice.Text = dt.Rows[0]["farmerproduct_price"].ToString();
            stock = Convert.ToInt32(dt.Rows[0]["farmerproduct_stock"].ToString());
            if (dt.Rows.Count > 0)
            {

                if (stock == 0)
                {
                    Response.Write("<script>alert('out of stock')</script>");
                }
            

                else
                {
                    MultiView1.ActiveViewIndex = 1;
                }
                }
            

        }   

        
    } 

    
            
            
                
            
            

        

        //if (e.CommandName == "wish")
        //{
        //    Session["farmerpid"] = e.CommandArgument.ToString();
        //    IdNo = Convert.ToInt32(Session["farmerpid"].ToString());
        //    string upQry1 = "update tbl_farmerproductbooking set wishlist_status='1' where farmerproduct_id='" + IdNo + "'";
        //    SqlCommand cmd = new SqlCommand(upQry1, con);
        //    cmd.ExecuteNonQuery();
        //    Response.Redirect("PineappleOrders.aspx");

        //}
     


    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        int a, b, amount, price;
        a = Convert.ToInt32(txtquantity.Text);
        b = Convert.ToInt32(txtstockquantity.Text);
        price = Convert.ToInt32(txtprice.Text);
        amount = price * b;
        

            if (a >= b)
            {
                lbamount.Text = amount.ToString();
                edId = Convert.ToInt32(Session["agencyid"].ToString());
                string InsQry = "insert into tbl_farmerproductbooking(productbooking_date,farmerproduct_id,productbooking_quantity,productbooking_amount,agency_id)values('" + DateTime.Now.ToShortDateString() + "','" + IdNo + "','" + txtstockquantity.Text + "','" + lbamount.Text + "','" + edId + "')";
                SqlCommand cmd = new SqlCommand(InsQry, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Your Order details Successfully Saved')</script>");


            }

            else if (b >= a)
            {
                Response.Write("<script>alert('!Required quantity is higher than quantity')</script>");
                //lbstock.Text = "!Required quantity is greater than quantity";
            }
           

            
      
        }
        



    protected void btnorder_Click(object sender, EventArgs e)
    {
        //Response.Redirect("PineappleOrderView.aspx");
        
    }
    protected void btnorder_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "book")
        {
            
            Response.Redirect("OrderView.aspx");
        }
    }



    protected void btndetails_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        
    

    }
    protected void DetailsView()
    {
        edId = Convert.ToInt32(Session["agencyid"].ToString());
        IdNo = Convert.ToInt32(Session["farmerpid"].ToString());
        string selQry = "select * from tbl_agencydeliverydetails where agency_id='" + edId + "'and farmerproduct_id='"+IdNo+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvdelivery.DataSource = dt;
        dvdelivery.DataBind();
    }
    protected void btnview_Click(object sender, EventArgs e)
    {
        
        MultiView1.ActiveViewIndex = 3;
        DetailsView();
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {

        
        if (flag == 1)
        {

            string upQry = "update tbl_agencydeliverydetails set deliverydetails_name='" + txtagency.Text + "',deliverydetails_address='" + txtagencyaddress.Text + "',deliverydetails_contact='" + txtcontactno.Text + "' where deliverydetails_id='" + Session["deliveryid"] + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
            Response.Write("<script>alert('Agency Details Successfully changed')</script>");

        }
        else
        {
            edId = Convert.ToInt32(Session["agencyid"].ToString());
            IdNo = Convert.ToInt32(Session["farmerpid"].ToString());
            string insQry = "insert into tbl_agencydeliverydetails(deliverydetails_name,deliverydetails_address,deliverydetails_contact,farmerproduct_id,agency_id)values('" + txtagency.Text + "','" + txtagencyaddress.Text + "','" + txtcontactno.Text + "','" + IdNo + "','" + edId + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Agency Details Successfully Saved')</script>");
        }
  

    }
    //protected void btnpayment_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("OrderView.aspx");
    //    MultiView1.ActiveViewIndex = 1;
    //}
    protected void dvdelivery_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void dvdelivery_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "change")
        {
             Session["deliveryid"] = Convert.ToInt32(e.CommandArgument.ToString());
             int deliveryID = Convert.ToInt32(Session["deliveryid"].ToString());
            
           string selQry = "select * from tbl_agencydeliverydetails where deliverydetails_id='" + deliveryID + "'";
           SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
           DataTable dt = new DataTable();
           adp.Fill(dt);
           txtagency.Text = dt.Rows[0]["deliverydetails_name"].ToString();
           txtagencyaddress.Text = dt.Rows[0]["deliverydetails_address"].ToString();
           txtcontactno.Text = dt.Rows[0]["deliverydetails_contact"].ToString();
           MultiView1.ActiveViewIndex = 2;
           flag = 1;
            
         

        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderView.aspx");
    }
}
