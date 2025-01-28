using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                DataList();
                fillsubtype();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
          
            
        }
    }
    protected void DataList()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string SelQry = "select * from tbl_shopproduct where shop_id='"+IdNo+"' ";
        SqlDataAdapter adp = new SqlDataAdapter(SelQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistshop.DataSource = dt;
        datalistshop.DataBind();
    }
    protected void datalistshop_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "vm")
        {
            Session["shoppid"] = e.CommandArgument.ToString();
            Response.Redirect("ShopSeeItemMore.aspx");
        }
    }
    protected void ddtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_shopproduct sh inner join tbl_subtype s on sh.subtype_id=s.subtype_id where s.subtype_id='" + ddsubtype.SelectedValue + "' and sh.shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistshop.DataSource = dt;
        datalistshop.DataBind();
    }


    
    protected void fillsubtype()
    {
        string SelQry = "select * from tbl_subtype";
        SqlDataAdapter adp = new SqlDataAdapter(SelQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddsubtype.DataValueField = "subtype_id";
        ddsubtype.DataTextField = "subtype_name";
        ddsubtype.DataSource = dt;
        ddsubtype.DataBind();
        ddsubtype.Items.Insert(0, "--select--");
    }
}