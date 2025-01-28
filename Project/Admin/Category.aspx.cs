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
            string upQry = "update tbl_category set category_name='" + txtname.Text + "' where category_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }
        else
        {
            string insQry = "insert into tbl_category(category_name)values('" + txtname.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        fillGrid();
        txtname.Text = "";
      
    }
    
    protected void fillGrid()
    {
        string selQry = "select * from tbl_category";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdcategory.DataSource = dt;
        grdcategory.DataBind();
    }
    protected void grdcategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdcategory.PageIndex=e.NewPageIndex;
        fillGrid();
    }
    protected void grdcategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {


        if (e.CommandName == "del")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_category where category_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();

        }

        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_category where category_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["category_name"].ToString();
            flag = 1;
            fillGrid();
        }

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
    }
}