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
    protected void grdback_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdback.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_feedback f inner join tbl_shop s on f.shop_id=s.shop_id";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdback.DataSource = dt;
        grdback.DataBind();
    }
}