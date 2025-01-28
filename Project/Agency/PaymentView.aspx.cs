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
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
            {
                Datalist();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
          
        }
    }
    protected void Datalist()
    {
        IdNo = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from tbl_category  c  inner join tbl_farmerproduct fp on c.category_id=fp.category_id inner join tbl_farmerproductbooking fb on fp.farmerproduct_id=fb.farmerproduct_id where fb.agency_id='" + Session["agencyid"] + "' and fb.payment_status=1";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistpayment.DataSource = dt;
        datalistpayment.DataBind();


    }
}