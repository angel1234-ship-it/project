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
    static int Bookid,IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                fillGrid();

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
        }
    }

    protected void grdfarmerpayment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "dely")
        {

            Session["bookid"] = e.CommandArgument.ToString();
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string upQry = "update tbl_productbooking set delivery_status='1' where productbooking_id='" + Bookid + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            fillGrid();

        }
    }
    protected void fillGrid()
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from  tbl_shop s inner join tbl_shopproduct sp  on s.shop_id=sp.shop_id inner join tbl_productbooking pb on sp.shopproduct_id =pb.shopproduct_id inner join tbl_farmer f on pb.farmer_id=f.farmer_id where s.shop_id='" + IdNo + "' and pb.payment_status='1' and pb.delivery_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfarmerpayment.DataSource = dt;
        grdfarmerpayment.DataBind();
    }
    protected void grdfarmerpayment_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfarmerpayment.PageIndex = e.NewPageIndex;
        fillGrid();
    }
}