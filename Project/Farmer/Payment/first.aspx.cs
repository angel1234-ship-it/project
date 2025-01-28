using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace MusicalInstruments.User.Payment
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=I_AM_AUGUSTINE;Initial Catalog=db_music;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Session["accno"] = TextBox1.Text;
                string insQry = "insert into tbl_payment(payment_fromaccount,payment_pin,cart_id,payment_toaccount)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + Session["cartID"] + "','************4367') ";
                SqlCommand cmd1 = new SqlCommand(insQry, con);
                cmd1.ExecuteNonQuery();
                Session["accno"] = TextBox1.Text;
                Response.Redirect("second.aspx");

            }
            else
            {
                Label1.Text = "Please accept the Terms & Conditions";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}