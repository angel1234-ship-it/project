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
    static int shoppID,FarmerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                shoppID = Convert.ToInt32(Session["shoppid"].ToString());
                string selQry = "select * from tbl_shopproduct sp inner join tbl_offerproduct op on sp.shopproduct_id=op.shopproduct_id  where op.shopproduct_id='" + shoppID + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtquantity.Text = dt.Rows[0]["shopproduct_stock"].ToString();
                    txtofferprice.Text = dt.Rows[0]["offerproduct_price"].ToString();
                }
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         
            
            
            

        }
    }

    protected void btnorder_Click(object sender, EventArgs e)
    {
        int a, b, amount, price;
        a = Convert.ToInt32(txtquantity.Text);
        b = Convert.ToInt32(txtrequiredquantity.Text);
        price = Convert.ToInt32(txtofferprice.Text);
        amount = price * b;
        if (b <= a)
        {
            lbamount.Text = amount.ToString();
            FarmerId = Convert.ToInt32(Session["farmerid"].ToString());
            string insQry = "insert into tbl_productbooking(productbooking_date,shopproduct_id,productbooking_quantity,productbooking_amount,farmer_id)values('" + DateTime.Now.ToString() + "','" + shoppID+ "','" + txtrequiredquantity.Text + "','" + lbamount.Text + "','" +FarmerId + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
        }

        else if (a < b)
        {
            lbamount.Text = "!Required quantity is higher than quantity";


        }
    }
    protected void btnorderdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductOrderDetailsView.aspx");
    }
}