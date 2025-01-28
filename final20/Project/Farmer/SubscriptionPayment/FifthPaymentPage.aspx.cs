using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Farmer_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int farmerID, purchaseId;
    protected void Page_Load(object sender, EventArgs e)
    {
          con.Open();
        if (!IsPostBack)
        {
            lblAmoubnt.Text = Session["amount"].ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTID.Text = GetISB();
    }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selQry = "select max(purchase_id) as Purchase from tbl_purchase";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        Session["max_id"] = dt.Rows[0]["Purchase"];

        string up = "update tbl_cart set cart_status='1',purchase_id='" + Session["max_id"] + "' where farmer_id='" + Session["farmerid"] + "' and cart_status='0'";
        SqlCommand cmd1 = new SqlCommand(up, con);
        cmd1.ExecuteNonQuery();
        string upQry = "update tbl_purchase set purchase_status='1' where farmer_id='" + Session["farmerid"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("~/Farmer/index.html");
        


        }
    private string GetISB()
    {
        string allowedChars = "";

        // allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
        allowedChars += "1,2,3,4,5,6,7,8,9,0";

        char[] sep = { ',' };
        string[] arr = allowedChars.Split(sep);

        string passwordString = "";

        string temp = "";

        Random rand = new Random();
        for (int i = 0; i < 4; i++)
        {
            temp = arr[rand.Next(0, arr.Length)];
            passwordString += temp;
        }
        return ("M-" + passwordString);
    }
    }
