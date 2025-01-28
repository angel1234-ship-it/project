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
    static int edID, flag,idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillregtype();
            fillGrid();
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_regfee set regfee_amount='" + txtfee.Text + "' where regfee_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
            fillGrid();
        }
        else
        {
            string insQry = "insert into tbl_regfee (regtype_id,regfee_amount)values('" + ddregtype.SelectedValue + "','" + txtfee.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }

    }
    protected void fillregtype()
    {
        string selQry = "select * from tbl_regtype ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddregtype.DataSource = dt;
        ddregtype.DataValueField = "regtype_id";
        ddregtype.DataTextField = "regtype_name";
        ddregtype.DataBind();
    }
    protected void fillGrid()
    {
        string SelQry = "select * from tbl_regtype t inner join tbl_regfee r on t.regtype_id=r.regtype_id";
        SqlDataAdapter adp = new SqlDataAdapter(SelQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdregfee.DataSource = dt;
        grdregfee.DataBind();
    }


    protected void grdregfee_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_regfee where regfee_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_regfee where regfee_id='"+edID+"'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry,con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtfee.Text = dt.Rows[0]["regfee_amount"].ToString();
            ddregtype.SelectedValue = dt.Rows[0]["regtype_id"].ToString();
            flag = 1;
            fillGrid();
        }

    }
}