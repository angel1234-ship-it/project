using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;


namespace MusicalInstruments.User.Payment
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=I_AM_AUGUSTINE;Initial Catalog=db_music;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (!IsPostBack)
            {
                string selQry = "select * from tbl_payment p inner join tbl_cart c on p.cart_id=c.cart_id inner join tbl_user u on u.user_id=c.user_id where p.cart_id='" + Session["cartID"] + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                lblAmoubnt.Text = dt.Rows[0]["cart_totalamount"].ToString();
                lblDate.Text = dt.Rows[0]["payment_date"].ToString();
                lblTID.Text = GetISB();

            }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strIsb = GetISB();

            string up2Qry = "update tbl_payment set transactionid='"+lblTID.Text+"' where cart_id='" + Session["cartID"] + "'";
            SqlCommand cmd2 = new SqlCommand(up2Qry, con);
            cmd2.ExecuteNonQuery();

            Response.Redirect("../UserHome.aspx");
        }
    }
}