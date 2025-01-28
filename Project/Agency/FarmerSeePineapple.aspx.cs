using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {
                DataList();
                fillcategory();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
     
        }

    }

    protected void DataList()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_farmerproduct where farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistpineapple.DataSource = dt;
        datalistpineapple.DataBind();
    }
    protected void datalistpineapple_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "vm")
        {
            Session["farmerpid"] = e.CommandArgument.ToString();
            Response.Redirect("FarmerSeePineappleMore.aspx");
        }
    }
    protected void ddcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select *  from tbl_farmerproduct fp inner join tbl_category c on fp.category_id=c.category_id where c.category_id='" + ddcategory.SelectedValue + "' and fp.farmer_id='"+IdNo+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistpineapple.DataSource = dt;
        datalistpineapple.DataBind();
    }

    
    protected void fillcategory(){
    
        string selQry = "select * from tbl_category";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddcategory.DataValueField = "category_id";
        ddcategory.DataTextField = "category_name";
        ddcategory.DataSource = dt;
        ddcategory.DataBind();
        ddcategory.Items.Insert(0, "--select--");
    }
}