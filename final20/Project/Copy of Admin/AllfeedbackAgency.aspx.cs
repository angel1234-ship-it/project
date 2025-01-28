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
        }

    }
    protected void grdfeed_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfeed.PageIndex = e.NewPageIndex;
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_feedback f inner join tbl_agency a on f.agency_id=a.agency_id";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfeed.DataSource = dt;
        grdfeed.DataBind();


    }
}