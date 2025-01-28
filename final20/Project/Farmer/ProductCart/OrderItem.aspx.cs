using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Farmer_ProductCart_Default : System.Web.UI.Page
{SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int ShoppId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if(!IsPostBack)
        {
            fillOrder();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int cartQTY = Convert.ToInt32(txtCat.Text);
        double total = Convert.ToDouble(lblTot.Text);
        string insQry = "insert into tbl_cart(cart_qty,cart_rate,cart_subtotal,shopproduct_id,farmer_id,cart_date)values('" + cartQTY + "','" + lblUnit.Text + "'," + total + ",'" + Session["shoppid"] + "','" + Session["farmerid"] + "','" + DateTime.Now.ToShortDateString() + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("CartDetails.aspx");
        
    }


    
    protected void fillOrder()
    {
        ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
        string selQry = "select * from tbl_shopproduct s inner join tbl_subtype st  on s.subtype_id=st.subtype_id inner join tbl_type t on st.type_id =t.type_id where s.shopproduct_id='" +ShoppId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {

            lblProduct.Text = dt.Rows[0]["shopproduct_name"].ToString();
            lblCat.Text = dt.Rows[0]["type_name"].ToString();
            lblUnit.Text = dt.Rows[0]["shopproduct_price"].ToString();
            double tot = (Convert.ToDouble(dt.Rows[0]["shopproduct_price"]) * Convert.ToDouble(txtCat.Text));
            lblTot.Text = tot.ToString() + ".00";

            Image1.ImageUrl = "~/Assests/ShopDocs/" + dt.Rows[0]["shopproduct_photo"].ToString();
        }
        

            
        
    }

    protected void txtCat_TextChanged(object sender, EventArgs e)
    {
        double Price = Convert.ToDouble(txtCat.Text);
        double Value = Convert.ToDouble(lblUnit.Text);
        double SubTotal = (Price * Value);
        lblTot.Text = SubTotal.ToString();
    }
    

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CartItem.aspx");

    }
}