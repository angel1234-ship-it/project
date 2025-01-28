using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MusicalInstruments.User.Payment
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=I_AM_AUGUSTINE;Initial Catalog=db_music;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (!IsPostBack)
            {

                fillBill();
               
            }
            
        }

        protected void fillBill()
        {
            string selQry = "select * from tbl_payment p inner join tbl_cart c on p.cart_id=c.cart_id inner join tbl_user u on u.user_id=c.user_id where p.cart_id='"+Session["cartID"] +"'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lbl_Payto.Text = dt.Rows[0]["payment_toaccount"].ToString();
            lbl_Amount.Text = dt.Rows[0]["cart_totalamount"].ToString();
            lblCardNumber.Text = Session["accno"].ToString();
            txtName.Text = dt.Rows[0]["user_name"].ToString();
            txtAddress.Text = dt.Rows[0]["cart_deliveryaddress"].ToString();
            txtEmail.Text = dt.Rows[0]["user_email"].ToString();
            txtPhone.Text = dt.Rows[0]["user_contact"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string selQry = "select * from tbl_payment p inner join tbl_cart c on p.cart_id=c.cart_id inner join tbl_user u on u.user_id=c.user_id inner join tbl_instrument i on i.instrument_id=c.instrument_id inner join tbl_seller s on s.seller_id=i.seller_id where p.cart_id='" + Session["cartid"] + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            int currentStock = Convert.ToInt32(dt.Rows[0]["instrument_stock"].ToString());  
            int selquandity = Convert.ToInt32(dt.Rows[0]["cart_quantity"].ToString());
            int newcurrentstock = currentStock - selquandity;

            string upQry = "update tbl_instrument set instrument_stock='" + newcurrentstock + "' where instrument_id='"+Session["insid"]+"'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();

            string up1Qry = "update tbl_cart set cart_paymentstatus='1' where cart_id='" + Session["cartid"] + "'";
            SqlCommand cmd1 = new SqlCommand(up1Qry, con);
            cmd1.ExecuteNonQuery();

            string up2Qry = "update tbl_payment set delivery_status='Paid',payment_date=GETDATE(),delivery_statusdate=GETDATE() where cart_id='" + Session["cartID"] + "'";
            SqlCommand cmd2 = new SqlCommand(up2Qry, con);
            cmd2.ExecuteNonQuery();
            Response.Redirect("thrid.aspx");
        }
    }
}