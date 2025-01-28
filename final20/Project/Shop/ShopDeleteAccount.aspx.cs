using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Shop_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
            if(!IsPostBack)
            {
                string shopID = Session["shopid"].ToString();
                if (shopID != null)
                {
                    Deactivate();
                }
                else
                {
                    Response.Redirect("../Guest/Login.aspx");
                }
       
            }

    }
    protected void btndeactivate_Click(object sender, EventArgs e)
    {
        if (rbreason2.Text != "")
        {
            string upQry = "update tbl_shop set shop_status='2',shop_activestatus='2',shop_reason='" + rbreason2.SelectedValue + "' where shop_id='" + Session["shopid"] + "'";
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
        lbalert.Text = "You won't able to access our services once you delete the account....!";
        lbalert.ForeColor = System.Drawing.Color.Red;
    }
}