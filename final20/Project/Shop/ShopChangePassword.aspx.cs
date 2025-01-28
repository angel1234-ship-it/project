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
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string shopID = Session["shopid"].ToString();
        if (shopID != null)
        {

        }
        else
        {
            Response.Redirect("../Guest/Login.aspx");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_shop where shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (txtcpassword.Text == dt.Rows[0]["shop_password"].ToString())
        {
            if (txtnewpass.Text == txtconfirmpass.Text)
            {
                IdNo = Convert.ToInt32(Session["shopid"].ToString());
                string upQry = "update tbl_shop set shop_password='" + txtnewpass.Text + "',shop_confirmpassword='" + txtconfirmpass.Text + "' where shop_id='" + IdNo + "'";
                SqlCommand cmd = new SqlCommand(upQry,con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Your password Successfully Changed')</script>");
            }
            else
            {
                lblmsg.Text = "Please Check Confirm Password";
            }
        }
        else
        {
            lblmesg.Text = "Invalid Login";

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopHomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcpassword.Text = "";
        txtnewpass.Text = "";
        txtconfirmpass.Text = "";
    }
}