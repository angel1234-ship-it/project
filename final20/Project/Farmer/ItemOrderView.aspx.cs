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
    static int IdNo, edId,BookId;
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
    protected void fillGrid()
    {
        IdNo=Convert.ToInt32(Session["farmerid"].ToString());
        edId = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry="select * from tbl_subtype s inner join tbl_shopproduct sh on s.subtype_id=sh.subtype_id inner join tbl_productbooking p on sh.shopproduct_id=p.shopproduct_id inner join tbl_farmer f on f.farmer_id=p.farmer_id where p.farmer_id='"+IdNo+"' and p.shopproduct_id='"+edId+"' and p.payment_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        Grdshop.DataSource = dt;
        Grdshop.DataBind();

    }

  
   
    protected void Grdshop_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Grdshop.PageIndex = e.NewPageIndex;
    }
    protected void Grdshop_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            BookId = Convert.ToInt32(Session["bookid"].ToString());
            string delQry = "delete from tbl_productbooking where productbooking_id='" + BookId + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();


        }
        if (e.CommandName == "pay")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            BookId = Convert.ToInt32(Session["bookid"].ToString());
            string upQry = "update tbl_productbooking set productbooking_status='1' where productbooking_id='" + BookId + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("PaymentMethod/First.aspx");
        }

    }
}
