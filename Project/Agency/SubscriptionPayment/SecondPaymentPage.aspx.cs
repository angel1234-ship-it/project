using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int agencyId;
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();
        if (!IsPostBack)
        {
            Billfill();
            lblCardNumber.Text = Session["cardno"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        Response.Redirect("ThirdPaymentPage.aspx");

    }
    protected void Billfill()
    {
        agencyId = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from tbl_regtype rt inner join tbl_subscriptionpayment p on rt.regtype_id=p.regtype_id inner join tbl_agency a on p.agency_id=a.agency_id where p.agency_id='" + agencyId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbl_Amount.Text = dt.Rows[0]["regtype_amount"].ToString();
            txtName.Text = dt.Rows[0]["agency_name"].ToString();
            txtAddress.Text = dt.Rows[0]["agency_address"].ToString();
            txtEmail.Text = dt.Rows[0]["agency_email"].ToString();
            txtPhone.Text = dt.Rows[0]["agency_contact"].ToString();
        }


        lbl_Payto.Text = "FAAR";
    }
}
