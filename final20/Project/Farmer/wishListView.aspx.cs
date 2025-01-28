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
    static int wishId,farmerId;
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
    protected void grdwish_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdwish.PageIndex = e.NewPageIndex;
    }
    protected void fillGrid()
    {

        farmerId = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_shopproduct sp inner join tbl_wishlist w on sp.shopproduct_id=w.shopproduct_id where w.farmer_id='" + farmerId +"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdwish.DataSource = dt;
        grdwish.DataBind();

    }
protected void grdwish_RowCommand(object sender, GridViewCommandEventArgs e)
{
    if (e.CommandName == "wish")
    {
        Session["shoppid"] = e.CommandArgument.ToString();
     
        
        Response.Redirect("ShopSeeItemMore.aspx");



    }
    if (e.CommandName == "del")
    {
        Session["wishid"] = e.CommandArgument.ToString();
        wishId = Convert.ToInt32(Session["wishid"].ToString());
        string delQry = "delete from tbl_wishlist where wishlist_id='" + wishId + "'";
        SqlCommand cmd = new SqlCommand(delQry, con);
        cmd.ExecuteNonQuery();
        fillGrid();
    }

}

}