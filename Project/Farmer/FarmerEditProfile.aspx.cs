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
        if(!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                IdNo = Convert.ToInt32(Session["farmerid"].ToString());
                string selQry = "select * from tbl_farmer where farmer_id='" + IdNo + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtename.Text = dt.Rows[0]["farmer_name"].ToString();
                txteaddress.Text = dt.Rows[0]["farmer_address"].ToString();
                txtecontact.Text = dt.Rows[0]["farmer_contact"].ToString();
                txteemail.Text = dt.Rows[0]["farmer_email"].ToString();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }
    protected void btnesave_Click(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(Session["farmerid"].ToString());
        string upQry = "update tbl_farmer set farmer_name='"+txtename.Text+"' ,farmer_address='" + txteaddress.Text + "',farmer_contact='" + txtecontact.Text + "',farmer_email='" + txteemail.Text + "' where farmer_id='" + IdNo + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Profile Successfully Updated')</script>");
        txtename.Text = "";
        txteaddress.Text = "";
        txtecontact.Text = "";
        txteemail.Text = "";
       
        

    }
}