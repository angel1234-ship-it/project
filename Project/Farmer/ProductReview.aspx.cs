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
    static int FarmerId,ShoppId,farmerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
                string selQry = "select * from tbl_shopproduct where shopproduct_id='" + ShoppId + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtproduct.Text = dt.Rows[0]["shopproduct_name"].ToString();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
          
            

        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        FarmerId = Convert.ToInt32(Session["farmerid"].ToString());
        ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry = "select * from tbl_productbooking where shopproduct_id='" + ShoppId + "' ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            farmerId = Convert.ToInt32(dt.Rows[0]["farmer_id"].ToString());

            if (FarmerId == farmerId)
            {

                string insQry = "insert into tbl_productreview(review_content,review_date,shopproduct_id,farmer_id)values('" + txtreview.Text + "','" + DateTime.Now.ToShortDateString() + "','" + ShoppId + "','" + FarmerId + "')";
                SqlCommand cmd = new SqlCommand(insQry, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('your product review is added')</script>");
                
            }
        }
        else
        {
            Response.Write("<script>alert('You cannot review this product because your are not purchased this product')</script>");
        }

        
    }


    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtreview.Text = "";
    }
}