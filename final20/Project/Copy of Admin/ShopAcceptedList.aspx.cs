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
    static int idNo;
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

        con.Open();
        if (!IsPostBack)
        {
            fillGrid();
        }
    }
    protected void grdshopaccepted_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdshopaccepted.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void grdshopaccepted_RowCommand(object sender, GridViewCommandEventArgs e)
    {


        if (e.CommandName == "rej")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_shop set shop_status='2' where shop_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
    }
          protected void fillGrid()
    {
        string selQry = "select * from tbl_shop s inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where s.shop_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdshopaccepted.DataSource = dt;
        grdshopaccepted.DataBind();
    }


          protected void lbshaccept_Click(object sender, EventArgs e)
          {
              Response.Redirect("HomePage.aspx");
          }
       
}