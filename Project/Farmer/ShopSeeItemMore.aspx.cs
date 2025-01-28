using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo,edId,ShoppId,farmerId,wishId,stock,flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                DataList();
                MultiView1.ActiveViewIndex = 0;
                DetailsView1();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
            
           
        }

    }
    protected void DataList()
    {

        IdNo = Convert.ToInt32(Session["shoppid"].ToString());
        string SelQry = "select * from  tbl_shopproduct where shopproduct_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(SelQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvitemmore.DataSource = dt;
        dvitemmore.DataBind();
    }



    protected void dvitemmore_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "buy")
        {
            Session["shoppid"] = e.CommandArgument.ToString();
            MultiView1.ActiveViewIndex = 1;
            IdNo = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry="select shopproduct_stock,shopproduct_price  from tbl_shopproduct  where shopproduct_id='"+IdNo+"'";
            SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
            DataTable dt=new DataTable();
            adp.Fill(dt);
            txtquantity.Text=dt.Rows[0]["shopproduct_stock"].ToString();
            txtprice.Text = dt.Rows[0]["shopproduct_price"].ToString();
            stock = Convert.ToInt32(dt.Rows[0]["shopproduct_stock"].ToString());
            if (dt.Rows.Count > 0)
            {
                if (stock == 0)
                {
                    Response.Write("<script>alert('Out of Stock')</script>");
                    MultiView1.ActiveViewIndex = 0;
                }
                else
                {
                    MultiView1.ActiveViewIndex = 1;
                }
            }

        }
        if (e.CommandName == "wish")
        {

            Session["shoppid"] = e.CommandArgument.ToString();
            ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
            farmerId = Convert.ToInt32(Session["farmerid"].ToString());
            string selQry = "select * from tbl_wishlist where  shopproduct_id='" + ShoppId + "' and farmer_id='" + farmerId + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                wishId = Convert.ToInt32(dt.Rows[0]["wishlist_id"].ToString());
                string upQry = "update tbl_wishlist set wishlist_date='" + DateTime.Now.ToShortDateString() + "' where wishlist_id='" + wishId + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);


            }
            else
            {
                string insQry = "insert into tbl_wishlist(farmer_id,shopproduct_id,wishlist_date)values('" + farmerId + "','" + ShoppId + "','" + DateTime.Now.ToShortDateString() + "')";
                SqlCommand cmd1 = new SqlCommand(insQry, con);
                cmd1.ExecuteNonQuery();
                Response.Write("<script>alert('Product is Successfully Added to Wishlist')</script>");
            }

        }
        if (e.CommandName == "review")
        {
            Session["reviewid"] = e.CommandArgument.ToString();
            Response.Redirect("ProductReviewView.aspx");
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        int a, b,amount,price;
        a = Convert.ToInt32(txtstockquantity.Text);
        b = Convert.ToInt32(txtquantity.Text);
        price = Convert.ToInt32(txtprice.Text);
        amount = price * a;
        if (a <= b)
        {
            lbamount.Text = amount.ToString();
            edId = Convert.ToInt32(Session["farmerid"].ToString());
            string insQry = "insert into tbl_productbooking(productbooking_date,shopproduct_id,productbooking_quantity,productbooking_amount,farmer_id)values('" + DateTime.Now.ToString() + "','" + IdNo + "','" + txtstockquantity.Text + "','" + lbamount.Text + "','"+edId+"')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('You Successfully Ordered')</script>");
            
        }

         else if (a > b)
        {
            //lbstock.Text = "!Required quantity is higher than quantity";
             Response.Write("<script>alert('!Required quantity is higher than quantity')</script>");


        }
        string selQry = "select * from tbl_shopproduct where shopproduct_id='" + ShoppId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);

        

    }
    protected void btnorder_Click(object sender, EventArgs e)
    {
        Response.Redirect("ItemOrderView.aspx");
    }
    protected void dvitemmore_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductReview.aspx");
      
    }
    protected void btnenterdetails_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        {

            string upQry = "update tbl_farmerdeliverydetails set deliverydetails_name='" + txtname.Text + "',deliverydetails_address='" + txtaddress.Text + "',deliverydetails_contact='" + txtcontactno.Text + "' where deliverydetails_id='" + Session["deliveryid"] + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
            Response.Write("<script>alert('Your delivery  details Successfully changed')</script>");

        }
        else
        {

            ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
            farmerId = Convert.ToInt32(Session["farmerid"].ToString());
            string insQry = "insert into tbl_farmerdeliverydetails(deliverydetails_name,deliverydetails_address,deliverydetails_contact,shopproduct_id,farmer_id)values('" + txtname.Text + "','" + txtaddress.Text + "','" + txtcontactno.Text + "','" + ShoppId + "','" + farmerId + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Delivery Details Successfully Saved')</script>");
        }
    }
    protected void btndetails_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    protected void btndetailsview_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 3;
        DetailsView1();

   
    }
    protected void DetailsView1()
    {
        farmerId = Convert.ToInt32(Session["farmerid"].ToString());
        ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry = "select * from tbl_farmerdeliverydetails where farmer_id='" + farmerId + "'and shopproduct_id='" + ShoppId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvdeliveryview.DataSource = dt;
        dvdeliveryview.DataBind();
    }
    //protected void btnpayment_Click(object sender, EventArgs e)
    //{
      
    //}
    protected void dvdeliveryview_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "change")
        {
            Session["deliveryid"] = Convert.ToInt32(e.CommandArgument.ToString());
            int deliveryID = Convert.ToInt32(Session["deliveryid"].ToString());
            string selQry = "select * from tbl_farmerdeliverydetails where deliverydetails_id='" + deliveryID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["deliverydetails_name"].ToString();
            txtaddress.Text = dt.Rows[0]["deliverydetails_address"].ToString();
            txtcontactno.Text = dt.Rows[0]["deliverydetails_contact"].ToString();
            MultiView1.ActiveViewIndex = 2;
            flag = 1;

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ItemOrderView.aspx");
        MultiView1.ActiveViewIndex = 1;
    }
}