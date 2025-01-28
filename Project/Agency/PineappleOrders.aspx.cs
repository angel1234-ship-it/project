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
    static int Bookid,idNo;
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


    protected void grdpineappleorder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string delQry = "delete from tbl_farmerproductbooking where productbooking_id='" + Bookid + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "payment")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string upQry1 = "update tbl_farmerproductbooking set productbooking_status='1' where productbooking_id='" + Bookid + "'";
            SqlCommand cmd1 = new SqlCommand(upQry1, con);
            cmd1.ExecuteNonQuery();
            Response.Redirect("PaymentMethod1/FirstPage.aspx");
        }

      
    }
    protected void grdpineappleorder_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdpineappleorder.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void fillGrid()
    {
        idNo=Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from tbl_category c inner join tbl_farmerproduct fp on c.category_id=fp.category_id inner join tbl_farmerproductbooking fb on fp.farmerproduct_id=fb.farmerproduct_id where fb.agency_id='" + idNo + "' and fb.payment_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdpineappleorder.DataSource = dt;
        grdpineappleorder.DataBind();

    }

}