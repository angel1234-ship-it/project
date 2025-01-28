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
    static int shopppID,Bookid;
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
    protected void fillGrid(){
        shopppID = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry = "select * from tbl_shopproduct  sp inner join tbl_offerproduct op on sp.shopproduct_id=op.shopproduct_id inner join tbl_offer o on op.offer_id=o.offer_id inner join tbl_productbooking pb on op.shopproduct_id=pb.shopproduct_id where pb.shopproduct_id='" + shopppID + "' and pb.payment_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdofferpayment.DataSource = dt;
        grdofferpayment.DataBind();


}
  
    protected void grdofferpayment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string delQry = "delete from tbl_productbooking where productbooking_id='" + Bookid + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        if (e.CommandName == "payment")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string upQry = "update tbl_productbooking set productbooking_status='1' where productbooking_id='" + Bookid + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("OfferProductPayment/FirstPaymentPage.aspx");
        }
    }
}