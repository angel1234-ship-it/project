using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Shop_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                Datalist();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }

        }
    }

    protected void dvsubscription_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "sub")
        {
            Session["regtypeid"] = Convert.ToInt32(e.CommandArgument.ToString());
            Response.Redirect("SubscriptionPayment/FirstPaymentPage.aspx");
        }
    }
    protected void Datalist(){
        string selQry = "select * from tbl_regtype where regtype_name='shop'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvsubscription.DataSource = dt;
        dvsubscription.DataBind();
               



    }
}