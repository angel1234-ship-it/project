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
    static int edID, flag;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillGrid();
                filltype();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            string upQry = "update tbl_subtype set subtype_name='" + txtsubtype.Text + "' where subtype_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;


        }
        else
        {
            string insQry = "insert into tbl_subtype(type_id,subtype_name)values('" + ddtype.SelectedValue + "','" + txtsubtype.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        txtsubtype.Text = "";
        fillGrid();

    }
    protected void filltype()
    {
        string selQry = "select * from tbl_type";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddtype.DataSource = dt;
        ddtype.DataTextField = "type_name";
        ddtype.DataValueField = "type_id";
        ddtype.DataBind();
        ddtype.Items.Insert(0, "--select--");
    }
    protected void fillGrid()
    {
        string selQry = "select  * from tbl_type t inner join tbl_subtype s on t.type_id=s.type_id ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdsubtype.DataSource = dt;
        grdsubtype.DataBind();
    }
    protected void grdsubtype_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_subtype where subtype_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_subtype where subtype_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtsubtype.Text = dt.Rows[0]["subtype_name"].ToString();
            flag = 1;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void grdsubtype_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdsubtype.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtsubtype.Text = "";
    }
}
        
    