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
        if (!IsPostBack)
        {
        }
    }

    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selagency = "select * from tbl_agency where agency_email='" + txtemail.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selagency, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        string selfarmer = "select * from tbl_farmer where farmer_email='" + txtemail.Text + "'";
        SqlDataAdapter adp1 = new SqlDataAdapter(selfarmer, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);

        string selShop = "select * from tbl_shop where shop_email='" + txtemail.Text + "'";
        SqlDataAdapter adpShop = new SqlDataAdapter(selShop, con);
        DataTable dtShop = new DataTable();
        adpShop.Fill(dtShop);

        if (dt.Rows.Count > 0)
        {
            txtqns.Text = dt.Rows[0]["agency_securityqns"].ToString();
        }


        else if (dt1.Rows.Count > 0)
        {
            txtqns.Text = dt1.Rows[0]["farmer_securityqns"].ToString();
        }
        else if (dtShop.Rows.Count > 0)
        {
            txtqns.Text = dtShop.Rows[0]["shop_securityqns"].ToString();
        }
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {

        string selAgency = "select * from tbl_agency where agency_email='" + txtemail.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selAgency, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        string selFarmer = "select * from tbl_farmer where farmer_email='" + txtemail.Text + "'";
        SqlDataAdapter adp1 = new SqlDataAdapter(selFarmer, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);

        string selShop = "select * from tbl_shop where shop_email='" + txtemail.Text + "'";
        SqlDataAdapter adp2 = new SqlDataAdapter(selShop, con);
        DataTable dt2= new DataTable();
        adp2.Fill(dt2);


        if (dt.Rows.Count > 0)
        {
            Session["emailidshop"] = "";
            Session["emailidfarmer"] = "";
            if (txtanswer.Text == dt.Rows[0]["agency_securityans"].ToString())
            {
                Session["agencyemailid"] = dt.Rows[0]["agency_email"].ToString();
                Session["agencyidPWD"] = dt.Rows[0]["agency_id"].ToString();
                
                Response.Redirect("NewPasswordForm.aspx");
            }
            else
            {
                lbalert.Text = "Your Answer is Incorrect Please Check!";
            }
        }
        else if(dt1.Rows.Count>0)
         {
             Session["agencyemailid"] = "";
             Session["emailidshop"] = "";
            if (txtanswer.Text == dt1.Rows[0]["farmer_securityans"].ToString())
            {
                Session["emailidfarmer"] = dt1.Rows[0]["farmer_email"].ToString();
                Session["farmeridPWD"] = dt1.Rows[0]["farmer_id"].ToString();
                
                Response.Redirect("NewPasswordForm.aspx");
            }
            else
            {
                lbalert.Text = "Your Answer is Incorrect Please Check!";
            }

            }
        else if(dt2.Rows.Count>0)
        {
            Session["agencyemailid"] = "";
            Session["emailidfarmer"] = "";
                  if (txtanswer.Text == dt2.Rows[0]["shop_securityans"].ToString())
            {
                Session["emailidshop"] = dt2.Rows[0]["shop_email"].ToString();
                Session["shopidPWD"] = dt2.Rows[0]["shop_id"].ToString();
                
                Response.Redirect("NewPasswordForm.aspx");
            }
            else
            {
                lbalert.Text = "Your Answer is Incorrect Please Check!";
            }

            }
        }

        
    }

