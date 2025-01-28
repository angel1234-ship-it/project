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
    static int cartId, i, Price, Qty, Total;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                fillGrid();
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         

        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductList.aspx");
    }
    protected void fillGrid()
    {

        string selQry = "select * from tbl_type t inner join tbl_subtype st on t.type_id=st.type_id inner join tbl_shopproduct sp on st.subtype_id=sp.subtype_id inner join tbl_cart c on sp.shopproduct_id=c.shopproduct_id where c.farmer_id='" + Session["farmerid"] + "' and c.cart_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        if (dt.Rows.Count > 0)
        {
            for (i = 0; i < dt.Rows.Count; i++)
            {

            }
        }

        string selQry1 = "select sum(cart_subtotal) as total from tbl_cart where farmer_id='" + Session["farmerid"] + "' and cart_status='0'";
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            lbltotal.Text = dt1.Rows[0]["total"].ToString();
            Session["amount"] = lbltotal.Text;
        }



    }



    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["cartid"] = e.CommandArgument.ToString();
            cartId = Convert.ToInt32(Session["cartid"].ToString());
            string delQry = "delete from tbl_cart where cart_id='" + cartId + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
            MultiView1.ActiveViewIndex = 0;

        }
        if (e.CommandName == "ed")
        {
            Session["cartid"] = e.CommandArgument.ToString();
            cartId = Convert.ToInt32(Session["cartid"].ToString());
            MultiView1.ActiveViewIndex = 1;
        }

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("../SubscriptionPayment/FirstPaymentPage.aspx");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillGrid();
        MultiView1.ActiveViewIndex = 0;
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        cartId = Convert.ToInt32(Session["cartid"].ToString());
        string selQry = "select * from tbl_cart where cart_id='" + cartId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Price = Convert.ToInt32(dt.Rows[0]["cart_rate"].ToString());
            Qty = Convert.ToInt32(txtqty.Text.ToString());
            Total = Price * Qty;

            string upQry = "update tbl_cart set cart_qty='" + txtqty.Text + "',cart_subtotal='" + Total + "' where cart_id='" + cartId + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
            MultiView1.ActiveViewIndex = 0;
            txtqty.Text = "";

        }
    }
}