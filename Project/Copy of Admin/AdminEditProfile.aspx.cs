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
        if (!IsPostBack)
        {
            idNo = Convert.ToInt32(Session["adminid"].ToString());
            string selQry = "select * from tbl_admin where admin_id='" + idNo + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["admin_name"].ToString();
            txtcontact.Text = dt.Rows[0]["admin_contactno"].ToString();
            txtemail.Text = dt.Rows[0]["admin_email"].ToString();
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["adminid"].ToString());
        string upQry = "update tbl_admin set admin_name='" + txtname.Text + "',admin_contactno='" + txtcontact.Text + "',admin_email='" + txtemail.Text + "' where admin_id='" + idNo + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        txtname.Text = "";
        txtcontact.Text = "";
        txtemail.Text = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}