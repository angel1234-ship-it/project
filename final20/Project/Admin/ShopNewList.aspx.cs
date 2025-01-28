using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static string EmailID, User, Pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }
    protected void grdshop_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdshop.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void fillGrid()
    {
        string selQry = "select * from   tbl_shop s  inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id  where s.shop_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdshop.DataSource = dt;
        grdshop.DataBind();
    }


    protected void grdshop_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "acp")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_shop set shop_status='1' ,shop_activestatus='1' where shop_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
            string selQry = "select * from  tbl_shop where shop_id='" + idNo + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                EmailID = dt.Rows[0]["shop_email"].ToString();
                User = dt.Rows[0]["shop_username"].ToString();
                Pass = dt.Rows[0]["shop_password"].ToString();
                ////Email Sendind Code

                MailMessage mail = new MailMessage();
                mail.To.Add(EmailID);
                mail.From = new MailAddress("faaronlineshoppingandsales@gmail.com");
                mail.Subject = "Registration  Acceptance!";

                string Body = "Your registration is  accepted  your username and password is   '" + User + "','" + Pass + "' ";
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
        if (e.CommandName == "rej")
        {
            int idNo = Convert.ToInt32(e.CommandArgument.ToString());
            string upQry = "update tbl_shop set shop_status='2' where shop_id='" + idNo + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();
        }
        
    }
    protected void lbshoplist_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}