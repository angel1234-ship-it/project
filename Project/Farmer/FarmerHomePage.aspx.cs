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
    static int RegtypeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Text = Session["farmername"].ToString();
    }
    protected void lbvfarmer_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerViewProfile.aspx");
    }
    protected void lbefarmer_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerEditProfile.aspx");
    }
    protected void lbcfarmer_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerChangePassword.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerPostComplaint.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("PostComplaintView.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerProduct.aspx");

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopSearch.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("PineappleOrderView.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookingStatusView.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyPayments.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pineappledelivereddetails.aspx");
    }

    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyShoppingOrders.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("wishListView.aspx");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerFeedback.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationFeeView.aspx");     
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("/ProductCart/ProductList.aspx");
    }
    protected void LinkButton13_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ProductCart/ProductList.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductCart/CartItem.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("CartOrders.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("AccountDeleteFarmer.aspx");
    }
}