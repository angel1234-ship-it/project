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
                DataList();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
        
        }

    }
    protected void DataList()
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_category c inner join tbl_farmerproduct fp on c.category_id=fp.category_id inner join tbl_farmerproductbooking fb on fp.farmerproduct_id=fb.farmerproduct_id inner join tbl_agency a on fb.agency_id=a.agency_id where fb.productbooking_status='1' and farmer_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistpayment.DataSource = dt;
        datalistpayment.DataBind();
    }

}