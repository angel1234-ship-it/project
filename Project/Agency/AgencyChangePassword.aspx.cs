using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string agencyID = Session["agencyid"].ToString();
        if (agencyID != null)
        {
            
        }
        else
        {
            Response.Redirect("../Guest/Login.aspx");
        }
    }

    protected void btnpsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from  tbl_agency where agency_id='" + idNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (txtcpassword.Text == dt.Rows[0]["agency_password"].ToString())
        {
            if (txtnewpassword.Text == txtconfirmpass.Text)
            {
                string upQry = "update tbl_agency set agency_password='" + txtnewpassword.Text + "',agency_confirmpass='"+txtconfirmpass.Text+"'where agency_id='" + idNo + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Your password successfully changed')</script>");
            }
            else
            {
                lblmsg.Text = "   Please Check Confirm Password";
            }
        }
        else
        {
            lblmesg.Text = "Invalid Password";
        }





    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyHomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcpassword.Text = "";
        txtnewpassword.Text = "";
        txtconfirmpass.Text = "";

    }
    

    }
