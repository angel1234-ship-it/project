using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Shop_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int subId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {

            string selQry = "select * from tbl_subscriptionpayment where shop_id='" + Session["shopid"] + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblAmoubnt.Text = dt.Rows[0]["subpayment_amount"].ToString();
                lblDate.Text = dt.Rows[0]["subpayment_date"].ToString();
                lblTID.Text = GetISB();
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string selQry = "select max(subpayment_id) as Subid   from tbl_subscriptionpayment";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);

        Session["max_id"] = dt.Rows[0]["Subid"].ToString();

        string upQry = "update  tbl_subscriptionpayment set subpayment_status='1' where subpayment_id='" + Session["max_id"] + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();
        Response.Redirect("../index.html");
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