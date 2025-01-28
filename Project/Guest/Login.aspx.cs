using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class Guest_Default : System.Web.UI.Page
{
   
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Shopregistration.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string selAdmin = "select * from tbl_admin where admin_email='" + txtemail.Text + "' and admin_password='" + txtpassword.Text + "'";
        SqlDataAdapter adpAdmin = new SqlDataAdapter(selAdmin, con);
        DataTable dtAdmin = new DataTable();
        adpAdmin.Fill(dtAdmin);

        string selAgency = "select * from tbl_agency where (agency_username='" + txtemail.Text + "' or agency_email='" + txtemail.Text + "') and agency_password='" +txtpassword.Text + "' and agency_status='1'";
        SqlDataAdapter adpAgency = new SqlDataAdapter(selAgency, con);
        DataTable dtAgency = new DataTable();
        adpAgency.Fill(dtAgency);

        string selFarmer = "select * from tbl_farmer where (farmer_username='" + txtemail.Text + "'or farmer_email='"+txtemail.Text+"') and farmer_password='" + txtpassword.Text + "' and farmer_status='1'";
        SqlDataAdapter adpFarmer = new SqlDataAdapter(selFarmer, con);
        DataTable dtFarmer = new DataTable();
        adpFarmer.Fill(dtFarmer);

        string selShop = "select * from tbl_shop where (shop_username='" + txtemail.Text + "' or shop_email='"+txtemail.Text+"') and shop_password='" + txtpassword.Text + "' and shop_status='1'";
        SqlDataAdapter adpShop = new SqlDataAdapter(selShop, con);
        DataTable dtShop = new DataTable();
        adpShop.Fill(dtShop);

      
         if (dtAdmin.Rows.Count > 0)
        {
            Session["adminid"] = dtAdmin.Rows[0]["admin_id"].ToString();
            Session["adminname"] = dtAdmin.Rows[0]["admin_name"].ToString();
            Response.Redirect("../Admin/index.html");
        }
         else if (dtAgency.Rows.Count > 0)
         {
             Session["subType"] = "Agency";
             Session["agencyid"] = dtAgency.Rows[0]["agency_id"].ToString();
             Session["agencyname"] = dtAgency.Rows[0]["agency_name"].ToString();
             Response.Redirect("../Agency/index.html");

         }
         else if (dtFarmer.Rows.Count > 0)
         {
             
             Session["subType"] = "Farmer";
             Session["farmerid"] = dtFarmer.Rows[0]["farmer_id"].ToString();
             Session["farmername"] = dtFarmer.Rows[0]["farmer_name"].ToString();
             Response.Redirect("../Farmer/index.html");
         }
         else if (dtShop.Rows.Count > 0)
         {
             Session["subType"] = "Shop";
             Session["shopid"] = dtShop.Rows[0]["shop_id"].ToString();
             Session["shopname"] = dtShop.Rows[0]["shop_name"].ToString();
             Response.Redirect("../Shop/index.html");
         }


         else
         {
             lblmsg.Text = "Invalid Login!!!";
         }
        


    }
    protected void lbfarmer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Farmerregistration.aspx");
    }
    protected void lbagency_Click(object sender, EventArgs e)
    {
        Response.Redirect("Agencyregistration.aspx");
    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Forgotpassword.aspx");
    }
}