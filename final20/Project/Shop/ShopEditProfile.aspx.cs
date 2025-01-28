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
                IdNo = Convert.ToInt32(Session["shopid"].ToString());
                string selQry = "select * from tbl_shop where shop_id='" + IdNo + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txteshopname.Text = dt.Rows[0]["shop_name"].ToString();
                txteownername.Text = dt.Rows[0]["shop_ownername"].ToString();
                txteemail.Text = dt.Rows[0]["shop_email"].ToString();
                txtecontact.Text = dt.Rows[0]["shop_contact"].ToString();
                txteaddress.Text = dt.Rows[0]["shop_address"].ToString();

            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }

    protected void btnesave_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["shopid"].ToString());
        string upQry = "update tbl_shop set shop_name='" + txteshopname.Text + "',shop_ownername='" + txteownername.Text + "',shop_email='" + txteemail.Text + "',shop_contact='" + txtecontact.Text + "',shop_address='" + txteaddress.Text + "' where shop_id='" + IdNo + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Profile Successfully Updated')</script>");
        txteshopname.Text = "";
        txteownername.Text = "";
        txteaddress.Text = "";
        txtecontact.Text = "";
        txteemail.Text = "";

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ShopHomePage.aspx");
    }
}