using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Farmer_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int farmerId, cartId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            Billfill();
            lblCardNumber.Text = Session["cardno"].ToString();
            lbl_Amount.Text = Session["amount"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string insQry = "insert into tbl_purchase(purchase_total,purchase_date,farmer_id)values('" + lbl_Amount.Text + "','" + DateTime.Now.ToShortDateString() + "','" + Session["farmerid"] + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        string upQry = "update tbl_cart set cart_status='1' where farmer_id='" + Session["farmer_id"] + "'";
        SqlCommand cmd1 = new SqlCommand(upQry,con);
        cmd1.ExecuteNonQuery();

        Response.Redirect("ThirdPaymentPage.aspx");
    }


    protected void Billfill()
    {
        farmerId = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_shop s inner join tbl_shopproduct sp on s.shop_id=sp.shop_id inner join   tbl_cart c  on sp.shopproduct_id=c.shopproduct_id inner join tbl_farmer f on c.farmer_id=f.farmer_id where c.farmer_id='" + farmerId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            txtName.Text = dt.Rows[0]["farmer_name"].ToString();
            txtAddress.Text = dt.Rows[0]["farmer_address"].ToString();
            txtEmail.Text = dt.Rows[0]["farmer_email"].ToString();
            txtPhone.Text = dt.Rows[0]["farmer_contact"].ToString();
            lbl_Payto.Text = dt.Rows[0]["shop_name"].ToString();

        }
    }
}


    
