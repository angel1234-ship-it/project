using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo;
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
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_farmer f inner join tbl_place p on f.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id where f.farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvfarmer.DataSource = dt;
        dvfarmer.DataBind();
    }


    protected void dvfarmer_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName == "se")
        {

            IdNo = Convert.ToInt32(Session["agencyid"].ToString());
            string selQry = "select * from tbl_subscriptionpayment where subpayment_status='1' and agency_id='" + IdNo + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int agencysub = Convert.ToInt32(dt.Rows[0]["agency_id"].ToString());
                if (agencysub == IdNo)
                {


                    Response.Redirect("FarmerSeePineapple.aspx");



                }
            }
            else
            {
                lbalert.Text = "You Can't See Pineapples Because You Are Not Subscribed ";

            }
        
        }
    }

}
