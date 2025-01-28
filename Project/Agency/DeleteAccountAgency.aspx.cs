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
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {
                Deactivate();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }
    protected void Deactivate()
    {
        lbalert.Text = "You won't able to access our services once you delete this account....!";
        //lbmsg.Text = "Please Select Reason For Deactivating the Account";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (rbreason.Text != "")
        {
            string upQry = "update tbl_agency set agency_activestatus='2',agency_status='2',agency_reason='" + rbreason.SelectedValue + "' where agency_id='" + Session["agencyid"] + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Account Deleted');window.location='/Index/index.html'</script>");
        }
        else
        {
            lbmessage.Text = "Please fill the reason....!";
        }
    }
}