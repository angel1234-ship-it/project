using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["adminid"].ToString());
        string selQry = "select * from  tbl_admin where admin_id='" + idNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (txtcpassword.Text == dt.Rows[0]["admin_password"].ToString())
        {
            if (txtnewpass.Text == txtconfirmpass.Text)
            {
                string upQry = "update tbl_admin set admin_password='" + txtnewpass.Text + "'where admin_id='" + idNo + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
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
        Response.Redirect("HomePage.aspx");
    }
}