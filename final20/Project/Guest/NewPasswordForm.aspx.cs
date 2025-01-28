using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
public partial class Guest_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static string email,farmerEmail,Shopemail;
    static int farmerID, ShopID,Agencyid;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
         string emailAgency="";
        emailAgency=Session["agencyemailid"].ToString();

        string emailFarmer = "";
        emailFarmer = Session["emailidfarmer"].ToString();


        string emailShop = "";
        emailShop = Session["emailidshop"].ToString();

       
        if (emailAgency != "")
            {
                string upQry = "update tbl_agency set agency_password='" + txtnew.Text + "',agency_confirmpass='" + txtconfirm.Text + "' where agency_id='" + Session["agencyidPWD"] + "'";
                SqlCommand cmd = new SqlCommand(upQry, con);
                cmd.ExecuteNonQuery();
                Mail();
                Response.Redirect("../Index/index.html");
                lbmsg.Text = Session["agencyemailid"].ToString();
            }

        else if (emailFarmer != "")
        {
              //farmerEmail = Convert.ToString(Session["emailidfarmer"]);

              //farmerID = Convert.ToInt32(Session["farmerid"].ToString());
              string upQry1 = "update tbl_farmer set farmer_password='" + txtnew.Text + "' where farmer_id='" + Session["farmeridPWD"] + "'";
              SqlCommand cmd1 = new SqlCommand(upQry1, con);
              cmd1.ExecuteNonQuery();
              Mail1();
            
              Response.Redirect("../Index/index.html");
        }

        else if (emailShop != "")
            {
                //Shopemail = Convert.ToString(Session["emailidshop"]);
                //ShopID = Convert.ToInt32(Session["shopid"].ToString());
                string upQry2 = "update tbl_shop set shop_password='" + txtnew.Text + "' where shop_id='" + Session["shopidPWD"] + "'";
                SqlCommand cmd2 = new SqlCommand(upQry2, con);
                cmd2.ExecuteNonQuery();
                Mail2();
                Response.Redirect("../Index/index.html");
            }
        

        
    }
    private void Mail()
    {
        email = Session["agencyemailid"].ToString();
        //Agencyid = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select agency_password from tbl_agency where agency_id='" + Session["agencyidPWD"] + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        string passWd = "";
        if (dt.Rows.Count > 0)
        {
            passWd = dt.Rows[0]["agency_password"].ToString();
            string EmailID = email;

            ////Email Sendind Code

            MailMessage mail = new MailMessage();
            mail.To.Add(EmailID);
            mail.From = new MailAddress("faaronlineshoppingandsales@gmail.com");
            mail.Subject = " New Password!!";

            string Body = "Your New Password is '" + passWd + "'";
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("faaronlineshoppingandsales@gmail.com", "ymxrifgqrzwkvjal");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            //Label1.Text = "Password send to u r mail...";
        }
    }
    private void Mail1()
    {
        farmerEmail = Convert.ToString(Session["emailidfarmer"].ToString());
        //farmerID = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry1 = "select farmer_password from tbl_farmer where farmer_id='" +Session["farmeridPWD"] + "'";
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);
        string passWd1 = "";

          if (dt1.Rows.Count > 0)
        {
            passWd1 = dt1.Rows[0]["farmer_password"].ToString();
            string EmailIDFarmer = farmerEmail;

            ////Email Sendind Code

            MailMessage mail = new MailMessage();
            mail.To.Add(EmailIDFarmer);
            mail.From = new MailAddress("faaronlineshoppingandsales@gmail.com");
            mail.Subject = " New Password!!";

            string Body = "Your New Password is '" + passWd1 + "'";
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("faaronlineshoppingandsales@gmail.com", "ymxrifgqrzwkvjal");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            //Label1.Text = "Password send to u r mail...";
        }
    }
    private void Mail2()
    {
        Shopemail = Convert.ToString(Session["emailidshop"]);
        //ShopID = Convert.ToInt32(Session["shopid"].ToString());
        string selQry2 = "select shop_password from tbl_shop where shop_id='" + Session["shopidPWD"] + "'";
        SqlDataAdapter adp2 = new SqlDataAdapter(selQry2, con);
        DataTable dt2 = new DataTable();
        adp2.Fill(dt2);
        string passWd2 = "";



        if (dt2.Rows.Count > 0)
        {
            passWd2 = dt2.Rows[0]["shop_password"].ToString();
            string EmailIDShop= Shopemail;

            ////Email Sendind Code

            MailMessage mail = new MailMessage();
            mail.To.Add(EmailIDShop);
            mail.From = new MailAddress("faaronlineshoppingandsales@gmail.com");
            mail.Subject = " New Password!!";

            string Body = "Your New Password is '" + passWd2 + "'";
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("faaronlineshoppingandsales@gmail.com", "ymxrifgqrzwkvjal");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            //Label1.Text = "Password send to u r mail...";
        }

    }
}