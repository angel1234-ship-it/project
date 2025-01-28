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
    static int IdNo,shoppid;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
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
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
            string selQry = "select * from tbl_shop s inner join tbl_shopproduct sp on s.shop_id=sp.shop_id inner join tbl_subtype st on sp.subtype_id=st.subtype_id inner join tbl_productbooking pb on sp.shopproduct_id=pb.shopproduct_id where s.shop_id='"+IdNo+"' and pb.payment_status='1'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            datalistorder.DataSource = dt;
            datalistorder.DataBind();
        
    }
    }
