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
    static int IdNo;
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
    protected void DetailsView()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_farmer f inner join tbl_place  p on f.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id where farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvfarmer.DataSource = dt;
        dvfarmer.DataBind();
    }

   
}