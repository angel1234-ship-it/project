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
    static int IdNo,edId,BookId;
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
        IdNo = Convert.ToInt32(Session["agencyid"].ToString());
        edId = Convert.ToInt32(Session["farmerpid"].ToString());
        string selQry = "select * from tbl_farmerproductbooking fb inner join tbl_farmerproduct fp on fb.farmerproduct_id=fp.farmerproduct_id inner join tbl_category c on c.category_id=fp.category_id where fb.agency_id='"+IdNo+"'and fb.farmerproduct_id='"+edId+"' and fb.payment_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dvbooking.DataSource = dt;
        dvbooking.DataBind();
    }


    protected void dvbooking_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            edId = Convert.ToInt32(Session["farmerpid"].ToString());
            Session["bookid"] = e.CommandArgument.ToString();
            BookId=Convert.ToInt32(Session["bookid"].ToString());
            string delQry = "delete from tbl_farmerproductbooking where  productbooking_id='"+BookId+"'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            DetailsView();
        }
        if (e.CommandName == "pay")
        {
            Session["bookid"] = e.CommandArgument.ToString();
            BookId = Convert.ToInt32(Session["bookid"].ToString());
            string upQry = "update tbl_farmerproductbooking set productbooking_status='1' where productbooking_id='" + BookId + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("PaymentMethod1/FirstPage.aspx");
        }
    }
    
}