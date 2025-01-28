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
    static int IdNo,shoppID;
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
             IdNo = Convert.ToInt32(Session["shopid"].ToString());
            string selQry1 = "select * from tbl_shopproduct sp inner join tbl_offerproduct op on sp.shopproduct_id=op.shopproduct_id inner join tbl_offer o on op.offer_id=o.offer_id where o.shop_id='" + IdNo + "'";
            SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);
            grdoffer.DataSource = dt1;
            grdoffer.DataBind();

    }

   
  

    protected void grdoffer_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdoffer.PageIndex = e.NewPageIndex;
        fillGrid();
        
    }
    protected void grdoffer_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "buy")
        {
            Session["shoppid"] = e.CommandArgument.ToString();
            Response.Redirect("OfferProductOrderEntery.aspx");
            
            
        }
    }
}