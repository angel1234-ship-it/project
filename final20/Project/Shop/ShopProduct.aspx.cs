using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Shop_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo, edID, flag,qty;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                fillsubtype();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
            //MultiView1.ActiveViewIndex = 0;
         
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            //IdNo = Convert.ToInt32(Session["shopid"].ToString());
            //string fileimage = Path.GetFileName(fileproduct.PostedFile.FileName.ToString());

            //fileproduct.SaveAs(Server.MapPath("../Assests/ShopDocs/" + fileimage));

            string upQry = "update tbl_shopproduct set shopproduct_name='" + txtproduct.Text + "',shopproduct_details='" + txtdetails.Text + "',shopproduct_price='" + txtprice.Text + "' where shopproduct_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {


            IdNo = Convert.ToInt32(Session["shopid"].ToString());
            string fileimage = Path.GetFileName(fileproduct.PostedFile.FileName.ToString());
            fileproduct.SaveAs(Server.MapPath("../Assests/ShopDocs/" + fileimage));
            string insQry = "insert into tbl_shopproduct(shop_id,shopproduct_name,shopproduct_details,shopproduct_photo,shopproduct_price,subtype_id)values('" + IdNo + "','" + txtproduct.Text + "','" + txtdetails.Text + "','" + fileimage + "','" + txtprice.Text + "','" + ddsubtype.SelectedValue + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            txtdetails.Text = "";
            txtproduct.Text = "";
            txtprice.Text = "";
           
        }

    }
    protected void fillsubtype()
    {
        string selQry = "select * from tbl_subtype ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddsubtype.DataSource = dt;
        ddsubtype.DataTextField = "subtype_name";
        ddsubtype.DataValueField = "subtype_id";
        ddsubtype.DataBind();
        ddsubtype.Items.Insert(0, "--select--");
    }
    protected void lbproductupload_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int shopsub = Convert.ToInt32(dt.Rows[0]["shop_id"].ToString());
            if (shopsub == IdNo)
            {

                MultiView1.ActiveViewIndex = 0;
                fillsubtype();



            }
        }
        else
        {
            lbalert.Text = "!You Can't Upload product because your are not subscribed.";

        }
       

    }

    protected void fillGrid()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subtype s inner join tbl_shopproduct p on p.subtype_id=s.subtype_id  where shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdproduct.DataSource = dt;
        grdproduct.DataBind();
    }
    protected void lbproductview_Click(object sender, EventArgs e)
    {

         IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int shopsub = Convert.ToInt32(dt.Rows[0]["shop_id"].ToString());
            if (shopsub == IdNo)
            {

                MultiView1.ActiveViewIndex = 1;
                 fillGrid();



            }
        }
        else
        {
            lbalert.Text = "!You Can't Upload product because your are not subscribed.";

        }
       

    
       
    }
    protected void grdproduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdproduct.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void grdproduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int IdNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_shopproduct where shopproduct_id='" + IdNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
            MultiView1.ActiveViewIndex = 3;

        }
        if (e.CommandName == "ed")
        {

            MultiView1.ActiveViewIndex = 0;
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_shopproduct where shopproduct_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            fillsubtype();
            txtproduct.Text = dt.Rows[0]["shopproduct_name"].ToString();
            txtdetails.Text = dt.Rows[0]["shopproduct_details"].ToString();
            txtprice.Text = dt.Rows[0]["shopproduct_price"].ToString();
            ddsubtype.SelectedValue = dt.Rows[0]["subtype_id"].ToString();
            //txtquantity.Text = dt.Rows[0]["shopproduct_quantity"].ToString();
            //fileproduct.PostedFile.FileName = dt.Rows[0]["shopproduct_photo"].ToString();
            flag = 1;
        }
    }
    protected void btnsave1_Click(object sender, EventArgs e)
    {

        string selQry = "select * from tbl_shopproduct where shopproduct_id='" + ddproduct.SelectedValue + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int StockQty = Convert.ToInt32(dt.Rows[0]["shopproduct_stock"].ToString());
            int qty = Convert.ToInt32(txtquantity.Text);
            int newStock = StockQty + qty;
            string upQry = "update tbl_shopproduct set shopproduct_stock='" + newStock + "' where shopproduct_id='" + ddproduct.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
        }




        string insQry = "insert into tbl_shopstock(shopstock_date,shopstock_quantity,shopproduct_id)values('" + txtdate.Text + "','" + txtquantity.Text + "','" + ddproduct.SelectedValue + "')";
        SqlCommand cmd1 = new SqlCommand(insQry, con);
        cmd1.ExecuteNonQuery();
        txtquantity.Text = "";
        txtdate.Text = "";
        fillGridView();
    }
    protected void lbstock_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int shopsub = Convert.ToInt32(dt.Rows[0]["shop_id"].ToString());
            if (shopsub == IdNo)
            {
                MultiView1.ActiveViewIndex = 3;
                fillProduct();
                fillGridView();



            }
        }
        else
        {
            lbalert.Text = "!You Can't Upload product because your are not subscribed.";

        }

      
    }


    //    protected void lbproductedit_Click(object sender, EventArgs e)
    //    {

    //        MultiView1.ActiveViewIndex = 2;

    //    }
    //    protected void btnsave_Click(object sender, EventArgs e)
    //    {

    //        edID = Convert.ToInt32(Session["sproductid"].ToString());
    //        string selQry = "select * from tbl_shopproduct where shopproduct_id='" + edID + "'";
    //        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    //        DataTable dt = new DataTable();
    //        adp.Fill(dt);
    //        txtproduct.Text = dt.Rows[0]["shopproduct_name"].ToString();
    //        txtdetails.Text = dt.Rows[0]["shopproduct_details"].ToString();
    //        txtprice.Text = dt.Rows[0]["shopproduct_price"].ToString();

    //    }

    protected void fillProduct()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_shopproduct where shop_id='" + IdNo + "' ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddproduct.DataSource = dt;
        ddproduct.DataTextField = "shopproduct_name";
        ddproduct.DataValueField = "shopproduct_id";
        ddproduct.DataBind();
        ddproduct.Items.Insert(0, "--select--");
    }
    protected void fillGrid1()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select  * from tbl_shopproduct where shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdstock.DataSource = dt;
        grdstock.DataBind();
    }

    protected void kbstockview_Click(object sender, EventArgs e)
    {

        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int shopsub = Convert.ToInt32(dt.Rows[0]["shop_id"].ToString());
            if (shopsub == IdNo)
            {
                MultiView1.ActiveViewIndex = 4;
                fillGrid1();



            }
        }
        else
        {
            lbalert.Text = "!You Can't Upload product because your are not subscribed.";

        }
      
    }
    protected void fillGridView()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_shopstock s inner join tbl_shopproduct sh on s.shopproduct_id=sh.shopproduct_id where sh. shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdstockview.DataSource = dt;
        grdstockview.DataBind();

    }

    protected void grdstockview_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            MultiView1.ActiveViewIndex = 3;

            int stockid = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry1 = "select * from tbl_shopstock where shopstock_id='" + stockid + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry1, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int pid = Convert.ToInt32(dt.Rows[0]["shopproduct_id"].ToString());
                int stock = Convert.ToInt32(dt.Rows[0]["shopstock_quantity"].ToString());
                string selQry2 = "select * from tbl_shopproduct where shopproduct_id='" + pid + "'";
                SqlDataAdapter adp1 = new SqlDataAdapter(selQry2, con);
                DataTable dt1 = new DataTable();
                adp1.Fill(dt1);
                string delQry = "delete from tbl_shopstock where shopstock_id='" + stockid + "'";
                SqlCommand cmd = new SqlCommand(delQry, con);
                cmd.ExecuteNonQuery();
                flag = 1;
                if (flag == 1)
                {
                    int stockqty = Convert.ToInt32(dt1.Rows[0]["shopproduct_stock"].ToString());
                    int stocknew = stockqty - stock;
                    string upQry = "update tbl_shopproduct set shopproduct_stock='" + stocknew + "' where shopproduct_id='"+pid+"'";
                    SqlCommand cmd1 = new SqlCommand(upQry, con);
                    cmd1.ExecuteNonQuery();
                }
            }


              

                 
                


            }
        }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtproduct.Text = "";
        txtdetails.Text = "";
        txtprice.Text = "";
        MultiView1.ActiveViewIndex = 0;

    }
    protected void btncancel1_Click(object sender, EventArgs e)
    {
        txtquantity.Text = "";
        txtdate.Text = "";
        MultiView1.ActiveViewIndex = 3;
    }
    protected void grdstockview_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdstockview.PageIndex = e.NewPageIndex;
        fillGridView();
    }
    protected void grdstock_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdstock.PageIndex = e.NewPageIndex;
        fillGrid1();
    }
}



        
    

   
   

    


    
