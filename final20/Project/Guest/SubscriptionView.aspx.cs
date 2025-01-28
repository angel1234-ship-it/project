using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Guest_Default : System.Web.UI.Page
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
    protected void grdfee_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "reg")
        {
            Session["regtypeid"] = Convert.ToInt32(Session["regtypeid"].ToString());
           
        }

    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_regtype rt inner join tbl_regfee rf on rt.regtype_id=rf.regtype_id ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfee.DataSource = dt;
        grdfee.DataBind();

    }

    protected void grdfee_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfee.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}