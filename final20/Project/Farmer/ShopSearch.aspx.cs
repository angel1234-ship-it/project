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
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                fillDatalist();
                fillDistrict();
                fillPlace();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }
    protected void fillDatalist()
    {
        string selQry = "select * from tbl_shop where shop_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistshop.DataSource = dt;
        datalistshop.DataBind();
    }

    protected void datalistshop_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "vm")
        {
            Session["shopid"] = e.CommandArgument.ToString();
            Response.Redirect("ShopViewMore.aspx");
        }
    }
    protected void dddistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_shop s inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id where d. district_id='" + dddistrict.SelectedValue + "' and shop_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistshop.DataSource = dt;
        datalistshop.DataBind();

    }
    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dddistrict.DataValueField = "district_id";
        dddistrict.DataTextField = "district_name";
        dddistrict.DataSource = dt;
        dddistrict.DataBind();
        dddistrict.Items.Insert(0, "--select--");
    }
    protected void fillPlace()
    {
        string SelQry = "select * from tbl_place ";
        SqlDataAdapter adp = new SqlDataAdapter(SelQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddplace.DataValueField = "place_id";
        ddplace.DataTextField = "place_name";
        ddplace.DataSource = dt;
        ddplace.DataBind();
        ddplace.Items.Insert(0, "--select--");
    }

    protected void ddplace_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from  tbl_shop s inner join tbl_place p  on s.place_id=p.place_id where p.place_id='" + ddplace.SelectedValue + "' and shop_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistshop.DataSource = dt;
        datalistshop.DataBind();

    }
}