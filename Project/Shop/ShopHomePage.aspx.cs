using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shop_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Text = Session["shopname"].ToString();

    }
    protected void lbvshop_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopViewProfile.aspx");
    }
    protected void lbeshop_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopEditProfile.aspx");
    }

    protected void lbcshop_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopChangePassword.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopPostComplaint.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopComplaintView.aspx");
    }
    protected void lbproduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopProduct.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ItemOrderView.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentBookingStatus.aspx");
    }
    protected void LinkButton4_Click1(object sender, EventArgs e)
    {
        Response.Redirect("FarmerPaymentView.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductDeliveryView.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductOffer.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOfferPrice.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopFeedback.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationFeeView.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopDeleteAccount.aspx");
    }
}