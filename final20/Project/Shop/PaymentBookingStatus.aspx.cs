using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Shop_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                Datalist();

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }
    protected void Datalist()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_subtype s inner join tbl_shopproduct sp on s.subtype_id=sp.subtype_id inner join tbl_productbooking pb on sp.shopproduct_id=pb.shopproduct_id inner join tbl_farmer f on pb.farmer_id=f.farmer_id where pb.productbooking_status='1' and shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistpayment.DataSource = dt;
        datalistpayment.DataBind();
    }
}