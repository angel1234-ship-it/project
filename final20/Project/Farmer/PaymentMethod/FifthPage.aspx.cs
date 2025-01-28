using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Farmer_PaymentMethod_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int Bookid, bookqty, totalstock, newstock, idno;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            Bookid = Convert.ToInt32(Session["bookid"].ToString());
            string selQry = "select * from tbl_productbooking where productbooking_id='" + Bookid + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lblAmoubnt.Text = dt.Rows[0]["productbooking_amount"].ToString();
            lblDate.Text = dt.Rows[0]["payment_date"].ToString();
            lblTID.Text = GetISB();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string upQry = "update tbl_productbooking set payment_status='1' where productbooking_id='" + Bookid + "'";
        SqlCommand cmd = new SqlCommand(upQry, con);
        cmd.ExecuteNonQuery();

        string selqry = "select * from tbl_shopproduct  sp inner join tbl_productbooking pb on sp.shopproduct_id=pb.shopproduct_id where pb.productbooking_id='" + Bookid + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selqry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            int productid = Convert.ToInt32(dt.Rows[0]["shopproduct_id"].ToString());
            int StockQty = Convert.ToInt32(dt.Rows[0]["shopproduct_stock"].ToString());
            int qty = Convert.ToInt32(dt.Rows[0]["productbooking_quantity"].ToString());
            int newStock = StockQty - qty;
            string upQry1 = "update tbl_shopproduct set shopproduct_stock='" + newStock + "' where shopproduct_id='" + productid + "'";
            SqlCommand cmd1 = new SqlCommand(upQry1, con);
            cmd1.ExecuteNonQuery();

        }


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