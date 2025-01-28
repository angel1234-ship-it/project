using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_PaymentMethod1_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
            {
                Session["cardno"] = TextBox1.Text;
                  Response.Redirect("SecondPage.aspx");

            }
            else
            {
                Label1.Text = "Please accept the Terms & Conditions";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
        
    
