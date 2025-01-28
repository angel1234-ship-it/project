using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
        }
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["agencyid"].ToString());
        string insQry = "insert into tbl_complaint(agency_id,complaint_title,complaint_content,complaint_date) values('" + idNo + "','" + txttitle.Text + "','" + txtcomplaint.Text + "','" + DateTime.Now.ToShortDateString() + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Complaint Successfully Posted')</script>");
        txttitle.Text = "";
        txtcomplaint.Text = "";

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txttitle.Text = "";
        txtcomplaint.Text = "";
    }
}