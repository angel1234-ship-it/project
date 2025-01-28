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
                idNo = Convert.ToInt32(Session["agencyid"].ToString());
                string selQry = "select * from tbl_agency where agency_id='" + idNo + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtaname.Text = dt.Rows[0]["agency_name"].ToString();
                txtacontact.Text = dt.Rows[0]["agency_contact"].ToString();
                txtaemail.Text = dt.Rows[0]["agency_email"].ToString();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["agencyid"].ToString());
        string upQry="update tbl_agency set agency_name='"+txtaname.Text+"',agency_contact='"+txtacontact.Text+"',agency_email='"+txtaemail.Text+"' where agency_id='"+idNo+"'";
        SqlCommand cmd = new SqlCommand(upQry,con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Profile Successfully Updated')</script>");

        txtaname.Text = "";
        txtacontact.Text = "";
        txtaemail.Text = "";

    }
}