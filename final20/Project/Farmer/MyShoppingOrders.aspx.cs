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
    static int Farmerid;
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
        Farmerid = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry="select * from tbl_shopproduct sp inner join tbl_productbooking pb on sp.shopproduct_id =pb.shopproduct_id inner join tbl_farmer f on pb.farmer_id=f.farmer_id where pb.farmer_id='"+Farmerid+"'and pb.payment_status='1'";
        SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
        DataTable dt=new DataTable();
        adp.Fill(dt);
        Datalistproduct.DataSource=dt;
        Datalistproduct.DataBind();

    }
}