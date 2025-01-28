using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Text = Session["adminname"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("District.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Place.aspx");
    }
    protected void lbagencylist_Click(object sender, EventArgs e)
    {

        Response.Redirect("AgencyListNew.aspx");
    }


    protected void lbagencyrejectlist_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyRejectedList.aspx");
    }
    protected void lbagencyaccept_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyAcceptedList.aspx");
    }

    protected void lbfarmerlist_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerListNew.aspx");
    }

    protected void lbfarmeraccept_Click(object sender, EventArgs e)
    {
        Response.Redirect("FramerAcceptedList.aspx");
    }
    protected void lbfarmerreject_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerRejectedList.aspx");
    }
    protected void lbshoplist_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopNewList.aspx");
    }

    protected void lbshopaccept_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopAcceptedList.aspx");
    }
    protected void lbshopreject_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopRejectedList.aspx");
    }
    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("AdminViewProfile.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminEditProfile.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminChangePassword.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerPostComplaintView.aspx");

    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopPostComplaintView.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyPostComplaintView.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Category.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Type.aspx");
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        Response.Redirect("Subtype.aspx");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyListNew.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistartionType.aspx");
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationFee.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("AllfeedbackAgency.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Response.Redirect("AllFeedbackFarmers.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("AllFeedBacksShops.aspx");
    }
}