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
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillGrid();
            }
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }

         
    }
    protected void grdfeedback_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfeedback.PageIndex = e.NewPageIndex;
    }
    protected void fillGrid(){
        string selQry = "select * from tbl_feedback fb inner join tbl_farmer f on f.farmer_id=fb.farmer_id";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfeedback.DataSource = dt;
        grdfeedback.DataBind();
    }
}