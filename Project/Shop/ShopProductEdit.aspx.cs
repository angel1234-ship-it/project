using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;


public partial class Shop_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                idNo = Convert.ToInt32(Session["shopid"].ToString());
                string selQry = "select * from tbl_shopproduct where shop_id='" + idNo + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtproductname.Text = dt.Rows[0]["shopproduct_name"].ToString();
                txtdetails.Text = dt.Rows[0]["shopproduct_details"].ToString();
                txtprice.Text = dt.Rows[0]["shopproduct_price"].ToString();

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        idNo = Convert.ToInt32(Session["shopid"].ToString());
        string upQry = "update tbl_shopproduct set shopproduct_name='" + txtproductname.Text + "',shopproduct_details='" + txtdetails.Text + "',shopproduct_photo='"+fileimage+ "',shopproduct_price='" + txtprice.Text + "' where shop_id='" + idNo + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        txtproductname.Text = "";
        txtdetails.Text = "";
        txtprice.Text="";

    }

    
}