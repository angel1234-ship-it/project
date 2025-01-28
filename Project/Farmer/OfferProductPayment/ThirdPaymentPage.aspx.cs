using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Farmer_OfferProductPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
        }

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        i = i + 1;
        if (i == 2)
        {
            i = 0;
            Response.Redirect("FourthPaymentPage.aspx");
        }
       
    }
}