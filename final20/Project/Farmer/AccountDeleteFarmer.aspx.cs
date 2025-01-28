using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                Deactivate();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
          
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (rdreason1.Text != "")
        {

            string upQry = "update tbl_farmer set farmer_activestatus='2',farmer_reason='" + rdreason1.SelectedValue + "',farmer_status='2' where farmer_id='" + Session["farmerid"] + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Account Deleted');window.location='/Index/index.html'</script>");
        }
        else
        {
            lbmessage.Text = "Please fill the reason....!";
        }
    }
    protected void Deactivate()
    {
        lbalert.Text = "You won't able to access our services once you delete this account....!";
        

    }
}