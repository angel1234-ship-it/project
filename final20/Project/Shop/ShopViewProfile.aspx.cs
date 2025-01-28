using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Shop_Default : System.Web.UI.Page
{
     
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int IdNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
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
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select  * from tbl_shop s inner join tbl_place p on s.place_id=p.place_id inner join tbl_district d on p.district_id=d.district_id where shop_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvshopview.DataSource = dt;
        dvshopview.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopHomePage.aspx");
    }
}