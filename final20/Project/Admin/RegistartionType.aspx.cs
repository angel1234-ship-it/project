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
    static int  edID,flag,IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }


        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if(flag==1)
        {
            string UpQry="update tbl_regtype set regtype_name='"+txtregtype.Text+"',regtype_validity='"+txtvalidity.Text+"',regtype_amount='"+txtamount.Text+"' where regtype_id='"+edID+"'";
            SqlCommand cmd=new SqlCommand(UpQry,con);
            cmd.ExecuteNonQuery();
            flag=0;
            fillGrid();


        }
        else
        {
        string insQry = "insert into tbl_regtype(regtype_name,regtype_validity,regtype_amount)values('" + txtregtype.Text + "','"+txtvalidity.Text+"','"+txtamount.Text+"')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        fillGrid();
        }
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_regtype";
        SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdregtype.DataSource = dt;
        grdregtype.DataBind();

    }
    protected void grdregtype_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdregtype.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void grdregtype_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            IdNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_regtype where regtype_id='" + IdNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
         
        }
        if(e.CommandName=="ed")
        {
            edID=Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_regtype where regtype_id='" + edID + "'";
            SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
            DataTable dt=new DataTable();
            adp.Fill(dt);
            txtregtype.Text=dt.Rows[0]["regtype_name"].ToString();
            txtvalidity.Text = dt.Rows[0]["regtype_validity"].ToString();
            txtamount.Text = dt.Rows[0]["regtype_amount"].ToString();
            flag=1;
            fillGrid();
        }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtregtype.Text = "";
        txtvalidity.Text = "";
        txtamount.Text = "";
    }
}