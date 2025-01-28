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
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();
        string farmerID = Session["farmerid"].ToString();
        if (farmerID != null)
        {

        }
        else
        {
            Response.Redirect("../Guest/Login.aspx");
        }
    }

    protected void btncsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from  tbl_farmer where farmer_id='" + idNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (txtcpassword.Text == dt.Rows[0]["farmer_password"].ToString())
        {
            if (txtnewpass.Text == txtconfirmpass.Text)
            {
                string upQry = "update tbl_farmer set farmer_password='" + txtnewpass.Text + "',farmer_confirmpassword='" + txtconfirmpass.Text + "'where farmer_id='" + idNo + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Your Password Successfully Changed')</script>");
            }
            else
            {
                lblmsg.Text = "   Please Check Confirm Password";
            }
        }
        else
        {
            lblmseg.Text = "Invalid Password";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerHomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcpassword.Text = "";
        txtnewpass.Text = "";
        txtconfirmpass.Text = "";
    }
}