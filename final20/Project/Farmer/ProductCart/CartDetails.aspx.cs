using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Farmer_ProductCart_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int cartId,farmerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void fillGrid()
    {
        string selQry1 = "select * from tbl_cart ";
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            cartId = Convert.ToInt32(dt1.Rows[0]["cart_id"].ToString());
            string selQry = "select * from tbl_type t inner join tbl_subtype s on t.type_id=s.type_id inner join tbl_shopproduct sp on s.subtype_id=sp.subtype_id inner join tbl_cart c on sp.shopproduct_id=c.shopproduct_id where  c.farmer_id='"+Session["farmerid"]+"'and c.cart_status='0'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            grdcart.DataSource = dt;
            grdcart.DataBind();

        }
    }
}