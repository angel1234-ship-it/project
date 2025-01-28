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
    protected void btnsend_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["farmerid"].ToString());
        string insQry = "insert into tbl_complaint(complaint_date,complaint_title,farmer_id,complaint_content)values('" + DateTime.Now.ToShortDateString() + "','" + txttitle.Text + "','"+idNo+"','" + txtcomplaint.Text + "')";
        SqlCommand cmd = new SqlCommand(insQry,con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Complaint Successfully Completed')</script>");
        txtcomplaint.Text = "";
        txttitle.Text = "";

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txttitle.Text = "";
        txtcomplaint.Text = "";
      
    }
}