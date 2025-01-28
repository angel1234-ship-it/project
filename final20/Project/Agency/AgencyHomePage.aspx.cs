using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Text = Session["agencyname"].ToString();
    }

    protected void lbviewprofile_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyViewProfile.aspx");
    }
    protected void lbeditprofile_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyEditProfile.aspx");
    }
    protected void lbchangepass_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyChangePassword.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyPostComplaint.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyPostComplaintView.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("FarmerSearch.aspx");

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("PineappleOrders.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentView.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgencyFeedBack.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistrationfeeView.aspx");
        
       
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteAccountAgency.aspx");
    }
}