using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Farmer_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int farmerID,RegID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
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
            Session["regtypeid"] = Convert.ToInt32(e.CommandArgument.ToString());
            RegID = Convert.ToInt32(Session["regtypeid"].ToString());


            Response.Redirect("RegistrationPayment/FirstPage.aspx");
        }
    }
    protected void DetailsView()
    {
        if (Session["subType"] == "Farmer")
        {

            string selQry = "select * from tbl_regtype where regtype_name='Farmer' ";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dvsub.DataSource = dt;
           dvsub.DataBind();
        } 

        }
    }


    



   
