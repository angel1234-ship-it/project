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
    static int edID, flag;
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            if (Session["adminid"] != null)
            {
                string adminID = Session["adminid"].ToString();
                if (adminID != null)
                {
                    fillGrid();
                    fillDistrict();
                }
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
            string upQry = "update tbl_place set place_name='" + txtname.Text + "',place_pincode='" + txtpin.Text + "',district_id='"+dddistrict.SelectedValue+"' where place_id='" + edID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            flag = 0;
        }

        else
        {


            string insQry = "insert into tbl_place(district_id,place_name,place_pincode)values('" + dddistrict.SelectedValue + "','" + txtname.Text + "','" + txtpin.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }
        fillGrid();
        txtname.Text = "";
        txtpin.Text = "";
    }

    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dddistrict.DataSource = dt;
        dddistrict.DataTextField = "district_name";
        dddistrict.DataValueField = "district_id";
        dddistrict.DataBind();
        dddistrict.Items.Insert(0, "--select--");
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_place p inner join tbl_district d on p.district_id=d.district_id";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdplace.DataSource = dt;
        grdplace.DataBind();
    }
    protected void grdplace_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_place where place_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();

        }
        if (e.CommandName == "ed")
        {
            edID = Convert.ToInt32(e.CommandArgument.ToString());
            string selQry = "select * from tbl_place where place_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtname.Text = dt.Rows[0]["place_name"].ToString();
            txtpin.Text = dt.Rows[0]["place_pincode"].ToString();
            dddistrict.SelectedValue = dt.Rows[0]["district_id"].ToString();
            flag = 1;

        }
    }
    protected void lblhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void grdplace_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdplace.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    //protected void txtname_TextChanged(object sender, EventArgs e)
    //{

    //}
    protected void txtpin_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place where place_pincode='" + txtpin.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg.Text = "Already Exists....";
            txtpin.Text = "";
        }
        else
        {
            lbmsg.Text = "Available....";
        }
    }
}