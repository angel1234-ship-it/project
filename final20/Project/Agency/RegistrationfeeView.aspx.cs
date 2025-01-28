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
    static int regID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {
                DetailsView();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }
    protected void dvsub_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "sub")
        {
            Session["regtypeid"] = e.CommandArgument.ToString();
            regID = Convert.ToInt32(Session["regtypeid"].ToString());
            Response.Redirect("SubscriptionPayment/FirstPaymentPage.aspx");
        }

    }
    protected void DetailsView()
    {
        

        string selQry1 = "select * from tbl_regtype where regtype_name='agency' ";
        SqlDataAdapter adp1 = new SqlDataAdapter(selQry1, con);
        DataTable dt1 = new DataTable();
        adp1.Fill(dt1);
        dvsub.DataSource = dt1;
        dvsub.DataBind();

    }
}