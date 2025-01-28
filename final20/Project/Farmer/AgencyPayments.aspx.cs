using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo,Bookid;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                fillGrid();

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }
    protected void GrdPayment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdPayment.PageIndex = e.NewPageIndex;
    }
    protected void fillGrid()
    {
        
        idNo=Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_category c inner join tbl_farmerproduct f on c.category_id=f.category_id inner join tbl_farmerproductbooking fb on f.farmerproduct_id=fb.farmerproduct_id inner join tbl_agency a on fb.agency_id=a.agency_id where f.farmer_id='" + idNo + "'  and fb.delivery_status='0' and fb.payment_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        GrdPayment.DataSource = dt;
        GrdPayment.DataBind();
    }

    protected void GrdPayment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "dely")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string upQry = "update tbl_farmerproductbooking set delivery_status='1' where productbooking_id='" + Bookid + "'and payment_status='1'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }

    }
}