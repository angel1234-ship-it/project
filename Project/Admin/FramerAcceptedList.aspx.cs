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

 

   
    protected void fillGrid()
    {
        string selQry = "select * from tbl_farmer f inner join tbl_place p on f.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where f.farmer_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfarmeraccepted.DataSource = dt;
        grdfarmeraccepted.DataBind();
    }
    protected void grdfarmeraccepted_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfarmeraccepted.PageIndex = e.NewPageIndex;
        fillGrid();
    }

    protected void grdfarmeraccepted_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        if (e.CommandName == "rej")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_farmer set farmer_status='2' where farmer_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
    }
    protected void lbfaccept_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void grdfarmeraccepted_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}