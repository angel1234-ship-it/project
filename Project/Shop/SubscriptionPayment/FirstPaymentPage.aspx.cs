using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Shop_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int regId, regAmount;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
     
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            
              Session["cardno"] = TextBox1.Text;
              string selQry = "select * from tbl_regtype where regtype_name='shop'";
              SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
              DataTable dt = new DataTable();
              adp.Fill(dt);
              int shopid = Convert.ToInt32(Session["shopid"].ToString());
              if (dt.Rows.Count > 0)
              {
                  regId = Convert.ToInt32(dt.Rows[0]["regtype_id"].ToString());
                  regAmount = Convert.ToInt32(dt.Rows[0]["regtype_amount"].ToString());
                  string insQry = "insert into tbl_subscriptionpayment(regtype_id,subpayment_date,subpayment_amount,shop_id)values('" + regId + "','" + DateTime.Now.ToShortDateString() + "','" + regAmount + "','" + Session["shopid"] + "')";
                  SqlCommand cmd = new SqlCommand(insQry, con);
                  cmd.ExecuteNonQuery();

               
              }
                Response.Redirect("SecondPaymentPage.aspx");
        }
            
            else
            {
                Label1.Text = "Please accept the Terms & Conditions";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }

