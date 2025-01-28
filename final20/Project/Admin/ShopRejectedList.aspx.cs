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
    protected void grdshopreject_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdshopreject.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void grdshopreject_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "acp")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_shop set shop_status='1' where shop_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }

    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_shop s inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on d.district_id=p.district_id where s.shop_status='2'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdshopreject.DataSource = dt;
        grdshopreject.DataBind();
    }

    protected void lbsreject_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}