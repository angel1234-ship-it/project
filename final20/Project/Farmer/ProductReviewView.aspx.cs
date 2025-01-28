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
    static int ShoppId;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {

            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                DataList();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    

    }
    protected void DataList()
    {
        ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry = "select * from tbl_shopproduct sp inner join tbl_productreview pr  on sp.shopproduct_id=pr.shopproduct_id inner join tbl_farmer f on f.farmer_id=pr.farmer_id where pr.shopproduct_id='" + ShoppId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistreview.DataSource = dt;
        datalistreview.DataBind();
    }

}