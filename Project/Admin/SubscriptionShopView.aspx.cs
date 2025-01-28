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
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }

    }
    protected void grdshop1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdshop1.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_regtype rt inner join tbl_subscriptionpayment s on rt.regtype_id=s.regtype_id inner join tbl_shop sp on s.shop_id=sp.shop_id where s.subpayment_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdshop1.DataSource = dt;
        grdshop1.DataBind();


    }
}