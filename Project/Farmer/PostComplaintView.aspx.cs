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
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                fillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }
    protected void fillGrid()
    {
        idNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_complaint Where farmer_id='" + idNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfarmer.DataSource = dt;
        grdfarmer.DataBind();
    }

    
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("FarmerHomePage.aspx");
    }
}