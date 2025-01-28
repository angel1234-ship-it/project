using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Farmer_PaymentMethod_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int Bookid;
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
        string upQry = "update tbl_productbooking set payment_date='" + DateTime.Now.ToShortDateString() + "' where productbooking_id='" + Bookid + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        
        Response.Redirect("ThirdPage.aspx");
    }
    protected void Billfill()
    {
        Bookid = Convert.ToInt32(Session["bookid"].ToString());
        string selQry = "select * from tbl_shop s  inner join tbl_shopproduct sp on s.shop_id=sp.shop_id inner join tbl_productbooking pb on sp.shopproduct_id=pb.shopproduct_id inner join tbl_farmer f on pb.farmer_id= f.farmer_id where pb.productbooking_id='" + Bookid + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        lbl_Payto.Text = dt.Rows[0]["shop_name"].ToString();
        lbl_Amount.Text = dt.Rows[0]["productbooking_amount"].ToString();
        txtName.Text = dt.Rows[0]["farmer_name"].ToString();
        txtAddress.Text = dt.Rows[0]["farmer_address"].ToString();
        txtEmail.Text = dt.Rows[0]["farmer_email"].ToString();
        txtPhone.Text = dt.Rows[0]["farmer_contact"].ToString();
    }

}