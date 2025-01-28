using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Agency_PaymentMethod1_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int Bookid;
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
        string upQry = "update tbl_farmerproductbooking set payment_date='" + DateTime.Now.ToShortDateString() + "' where productbooking_id='"+Bookid+"'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        Response.Redirect("ThirdPage.aspx");
       

    }
    protected void Billfill()
    {
        Bookid = Convert.ToInt32(Session["bookid"].ToString());
        string selQry = "select * from tbl_farmer f inner join tbl_farmerproduct fp on f.farmer_id=fp.farmer_id inner join tbl_farmerproductbooking fb on fp.farmerproduct_id=fb.farmerproduct_id inner join tbl_agency a on fb.agency_id= a.agency_id where fb.productbooking_id='" + Bookid + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        lbl_Payto.Text = dt.Rows[0]["farmer_name"].ToString();
        lbl_Amount.Text = dt.Rows[0]["productbooking_amount"].ToString();
        txtName.Text = dt.Rows[0]["agency_name"].ToString();
        txtAddress.Text = dt.Rows[0]["agency_address"].ToString();
        txtEmail.Text = dt.Rows[0]["agency_email"].ToString();
        txtPhone.Text = dt.Rows[0]["agency_contact"].ToString();
        
        

    }
}