using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Admin_AdminMaster : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            
            
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                
            }
                
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }


        }

    }
}
