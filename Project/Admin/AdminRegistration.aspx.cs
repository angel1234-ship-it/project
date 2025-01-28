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
    static int  edID,flag;
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();
        if (!IsPostBack)
        {
        fillGrid();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_admin set admin_name='" + txtname.Text + "',admin_contactno='" + txtcontact.Text + "',admin_email='" + txtemail.Text + "',admin_password='" + txtpassword.Text + "' where admin_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;

        }
        else
        {

            string insQry = "insert into tbl_admin(admin_name,admin_contactno,admin_email,admin_password)values('" + txtname.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        fillGrid();
        txtname.Text="";
        txtcontact.Text = "";
        txtemail.Text = "";
        txtpassword.Text = "";

    }


    protected void fillGrid()
    {
        string selQry = "select * from tbl_admin";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdadmin.DataSource = dt;
        grdadmin.DataBind();
    }

   
    protected void grdDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdadmin.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void grdadmin_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {

            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_admin where admin_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();

        }
        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_admin where admin_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["admin_name"].ToString();
            txtcontact.Text = dt.Rows[0]["admin_contactno"].ToString();
            txtemail.Text = dt.Rows[0]["admin_email"].ToString();
            txtpassword.Text = dt.Rows[0]["admin_password"].ToString();
            flag = 1;
            
        }

    }
    protected void txtcontact_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_admin where admin_contactno='" +txtcontact.Text+ "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg.Text = "Already Exists....";
            txtcontact.Text = "";

        }
        else
        {
            lbmsg.Text = "Available....";


        }

    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_admin where admin_email='" + txtemail.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg1.Text = "Already Exists....";
            txtemail.Text = "";

        }
        else
        {
            lbmsg1.Text = "Available....";


        }
    }
}