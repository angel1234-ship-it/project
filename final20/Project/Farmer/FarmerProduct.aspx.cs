using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo, edID, flag, farmersubID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        if (flag == 1)
        {
            string upQry = "update tbl_farmerproduct set farmerproduct_name='" + txtpinename.Text + "',farmerproduct_details='" + txtdetails.Text + "',farmerproduct_price='" + txtprice.Text + "' where farmerproduct_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            IdNo = Convert.ToInt32(Session["farmerid"].ToString());
            string fileimage = Path.GetFileName(fileproduct.PostedFile.FileName.ToString());
            fileproduct.SaveAs(Server.MapPath("../Assests/FarmerProduct/" + fileimage));
            string insQry = "insert into tbl_farmerproduct(farmer_id,farmerproduct_name,farmerproduct_details,farmerproduct_photo,farmerproduct_price,category_id)values('" + IdNo + "','" + txtpinename.Text + "','" + txtdetails.Text + "','" + fileimage + "','" + txtprice.Text + "','" + ddcategory.SelectedValue + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            txtpinename.Text = "";
            txtdetails.Text = "";
            txtprice.Text = "";
            
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and farmer_id='"+IdNo+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int farmersub = Convert.ToInt32(dt.Rows[0]["farmer_id"].ToString());
            if (farmersub == IdNo)
            {


                MultiView1.ActiveViewIndex = 0;
                fillcategory();




            }
        }
        else
        {
            lbalert.Text = "You Can't Upload product because your are not subscribed.";

        }
        
 
    }

    protected void fillcategory()
    {
        string selQry = "select * from tbl_category ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddcategory.DataSource = dt;
        ddcategory.DataTextField = "category_name";
        ddcategory.DataValueField = "category_id";
        ddcategory.DataBind();
        ddcategory.Items.Insert(0, "--select--");
    }
    protected void fillGrid()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_category c inner join tbl_farmerproduct fp on c.category_id=fp.category_id where fp.farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdpineapple.DataSource = dt;
        grdpineapple.DataBind();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int farmersub = Convert.ToInt32(dt.Rows[0]["farmer_id"].ToString());
            if (farmersub == IdNo)
            {


                MultiView1.ActiveViewIndex = 1;
                fillGrid();



            }
        }
            else
            {
                lbalert.Text = "You Can't Upload product because your are not subscribed.";

            }
        
 

    }
    protected void grdpineapple_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdpineapple.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void grdpineapple_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            IdNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_farmerproduct  where farmerproduct_id='" + IdNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            MultiView1.ActiveViewIndex = 0;
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_farmerproduct  where farmerproduct_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            fillcategory();
            ddcategory.Text = dt.Rows[0]["category_id"].ToString();
            txtpinename.Text = dt.Rows[0]["farmerproduct_name"].ToString();
            txtdetails.Text = dt.Rows[0]["farmerproduct_details"].ToString();
            txtprice.Text = dt.Rows[0]["farmerproduct_price"].ToString();

            flag = 1;
            fillGrid();
        }

    }

    protected void fillproduct()
    {
        {
            IdNo = Convert.ToInt32(Session["farmerid"].ToString());
            string selQry = "select * from tbl_farmerproduct where farmer_id='" + IdNo + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            ddproduct.DataSource = dt;
            ddproduct.DataTextField = "farmerproduct_name";
            ddproduct.DataValueField = "farmerproduct_id";
            ddproduct.DataBind();
            ddproduct.Items.Insert(0, "--select--");
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int farmersub = Convert.ToInt32(dt.Rows[0]["farmer_id"].ToString());
            if (farmersub == IdNo)
            {


                MultiView1.ActiveViewIndex = 2;
                fillproduct();
                fillGrid1();
                fillCategory1();


            }
        }
            else
            {
                lbalert.Text = "You Can't Upload product because your are not subscribed.";

            }
        
        
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_farmerproduct where farmerproduct_id='" + ddproduct.SelectedValue + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int StockQty = Convert.ToInt32(dt.Rows[0]["farmerproduct_stock"].ToString());
            int qty = Convert.ToInt32(txtquantity.Text);
            int newStock = StockQty + qty;
            string upQry = "update tbl_farmerproduct set farmerproduct_stock='" + newStock + "' where farmerproduct_id='" + ddproduct.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid1();
        }
        string insQry = "insert into tbl_farmerstock(farmerproduct_id,farmerstock_quantity,framerstock_date)values('" + ddproduct.SelectedValue + "','" + txtquantity.Text + "','" + DateTime.Now.ToShortDateString() + "')";
        SqlCommand cmd1 = new SqlCommand(insQry, con);
        cmd1.ExecuteNonQuery();
        fillGrid1();
        fillCategory1();
        txtquantity.Text = "";
    }
    protected void fillGrid1()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_farmerstock s inner join tbl_farmerproduct fp on s.farmerproduct_id=fp.farmerproduct_id where fp.farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdstock.DataSource = dt;
        grdstock.DataBind();
    }


    protected void grdstock_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdstock.PageIndex = e.NewPageIndex;
        fillGrid1();
    }
    protected void grdstockview_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdstockview.PageIndex = e.NewPageIndex;
        fillGrid2();
    }
    protected void fillGrid2()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_farmerproduct where farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdstockview.DataSource = dt;
        grdstockview.DataBind();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int farmersub = Convert.ToInt32(dt.Rows[0]["farmer_id"].ToString());
            if (farmersub == IdNo)
            {

                MultiView1.ActiveViewIndex = 3;
                fillGrid2();



            }
        }
            else
            {
                lbalert.Text = "You Can't Upload product because your are not subscribed.";

            }
        
      
    }
    protected void grdstock_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int stockid = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_farmerstock where farmerstock_id='" + stockid + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int pid = Convert.ToInt32(dt.Rows[0]["farmerproduct_id"].ToString());
                int stock = Convert.ToInt32(dt.Rows[0]["farmerstock_quantity"].ToString());
                string selQry1 = "select * from tbl_farmerproduct where farmerproduct_id='" + pid + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                string delQry = "delete from tbl_farmerstock where farmerstock_id='" + stockid + "'";
                SqlCommand cmd = new SqlCommand(delQry, con);
                cmd.ExecuteNonQuery();
                flag = 1;
                fillGrid1();
                if (flag == 1)
                {
                    int stockqty = Convert.ToInt32(dt1.Rows[0]["farmerproduct_stock"].ToString());
                    int stocknew = stockqty - stock;
                    string UpQry = "update tbl_farmerproduct set farmerproduct_stock='" + stocknew + "' where farmerproduct_id='" + pid + "'";
                    SqlCommand cmd1 = new SqlCommand(UpQry, con);
                    cmd1.ExecuteNonQuery();
                    flag = 0;
                    fillGrid1();
                }
            }
        }




    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtpinename.Text = "";
        txtdetails.Text = "";
        txtprice.Text = "";
        MultiView1.ActiveViewIndex = 0;
    }
    protected void btncancel1_Click(object sender, EventArgs e)
    {
        txtquantity.Text = "";
        MultiView1.ActiveViewIndex = 2;
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {
    }
    protected void fillCategory1()
    {
        string selQry = "select * from tbl_category ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddcategory1.DataSource = dt;
        ddcategory1.DataTextField = "category_name";
        ddcategory1.DataValueField = "category_id";
        ddcategory1.DataBind();
        ddcategory1.Items.Insert(0, "--select--");
    }
    protected void ddcategory1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_farmerproduct where category_id='" + ddcategory1.SelectedValue + "' and farmer_id='"+IdNo+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddproduct.DataSource = dt;
        ddproduct.DataTextField = "farmerproduct_name";
        ddproduct.DataValueField = "farmerproduct_id";
        ddproduct.DataBind();
        ddproduct.Items.Insert(0, "--select--");
    }
   
}

