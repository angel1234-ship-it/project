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
    static int idNo;
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
    protected void DetailsView()
    {
        idNo = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from tbl_agency a inner join tbl_place p on  a.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id where agency_id='" + idNo + "' ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvagency.DataSource = dt;
        dvagency.DataBind();

    }
}