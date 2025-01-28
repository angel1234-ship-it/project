using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
           MultiView1.ActiveViewIndex = 0;
        }
        
    }
    protected void fillGrid()
    {
      

        string selQry = "select * from tbl_complaint c inner join tbl_farmer f on c.farmer_id=f.farmer_id where complaint_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdadminpost.DataSource = dt;
        grdadminpost.DataBind();
    }
    protected void fillGrid1()
    {
        string selQry = "select * from tbl_complaint c inner join tbl_farmer f on c.farmer_id=f.farmer_id where complaint_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdadminsolved.DataSource = dt;
        grdadminsolved.DataBind();
    }
    protected void lbreply_Click(object sender, EventArgs e)
    {
    }
    protected void grdadminpost_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "reply")
        {
            Session["cid"] = e.CommandArgument.ToString();
            Response.Redirect("FarmerPostComplaintReply.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        fillGrid();
        MultiView1.ActiveViewIndex = 0;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        fillGrid1();
        MultiView1.ActiveViewIndex = 1;
    }
}