using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Shop_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int regId, regAmount;
    protected void Page_Load(object sender, EventArgs e)
    {
         con.Open();
        if (!IsPostBack)
        {
            lblCardNumber.Text = Session["cardno"].ToString();
            Billfill();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("ThirdPaymentPage.aspx");
    }
    protected void Billfill()
    {
        string selQry = "select * from tbl_regtype rt inner join tbl_subscriptionpayment p on rt.regtype_id=p.regtype_id inner join tbl_shop s on p.shop_id=s.shop_id where p.shop_id='" + Session["shopid"] + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbl_Amount.Text = dt.Rows[0]["regtype_amount"].ToString();
            txtName.Text = dt.Rows[0]["shop_name"].ToString();
            txtAddress.Text = dt.Rows[0]["shop_address"].ToString();
            txtEmail.Text = dt.Rows[0]["shop_email"].ToString();
            txtPhone.Text = dt.Rows[0]["shop_contact"].ToString();
        }


        lbl_Payto.Text = "FAAR";
    }

    }
