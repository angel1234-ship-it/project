using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int agencyId,FarmerPid,Bookid;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
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
        agencyId = Convert.ToInt32(Session["agencyid"].ToString());
        FarmerPid = Convert.ToInt32(Session["farmerpid"].ToString());
        string selQry = "select * from tbl_category c inner join tbl_farmerproduct fp on c.category_id=fp.category_id inner join tbl_farmerproductbooking fb on fp.farmerproduct_id=fb.farmerproduct_id where fb.farmerproduct_id='" + FarmerPid + "' and fb.agency_id='" + agencyId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvorder.DataSource = dt;
        dvorder.DataBind();


    }
    protected void dvorder_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dvorder.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void dvorder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "buy")
        {
            Bookid = Convert.ToInt32(e.CommandArgument.ToString());
            string delQry = "delete from tbl_farmerproductbooking where productbooking_id='" + Bookid + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();

        }

    }
    protected void btndelivery_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerSeePineappleMore.aspx");
        
    }
}