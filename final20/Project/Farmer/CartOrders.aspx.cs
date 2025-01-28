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
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
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
        string selQry = "select * from tbl_type t inner join tbl_subtype st on t.type_id=st.type_id inner join tbl_shopproduct sp on st.subtype_id=sp.subtype_id inner join tbl_cart c on sp.shopproduct_id=c.shopproduct_id inner join tbl_purchase p on c.purchase_id=p.purchase_id where p.farmer_id='" + Session["farmerid"] + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        DatalistCart.DataSource = dt;
        DatalistCart.DataBind();

    }
}