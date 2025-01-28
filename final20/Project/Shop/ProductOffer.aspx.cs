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
    static int Idno,Offerid,flag,edID,ShopID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                FillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
        
           
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            Offerid=Convert.ToInt32(Session["offerid"].ToString());
            string upQry = "update tbl_offer set offer_name='" + txtoffer.Text + "',offer_fromdate='" + txtfromdate.Text + "',offer_todate='" + txttodate.Text + "' where offer_id='" + Offerid + "'";
            SqlCommand cmd=new SqlCommand(upQry,con);
            cmd.ExecuteNonQuery();
            FillGrid();
            flag=0;
        }

        else
        {
        Idno = Convert.ToInt32(Session["shopid"].ToString());
        string insQry = "insert into tbl_offer (offer_name,offer_fromdate,offer_todate,shop_id) values('" + txtoffer.Text + "','" + txtfromdate.Text + "','" + txttodate.Text + "','" + Idno + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        FillGrid();
        }


    }


    protected void grdoffer_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdoffer.PageIndex = e.NewPageIndex;
        FillGrid();
    }
   
    protected void FillGrid()
    {
        ShopID= Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_offer where shop_id='"+ShopID+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdoffer.DataSource = dt;
        grdoffer.DataBind();
    }
    protected void grdoffer_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["offerid"] = e.CommandArgument.ToString();
            Offerid = Convert.ToInt32(Session["offerid"].ToString());
            string delQry = "delete from tbl_offer where offer_id='" + Offerid + "'";
            SqlCommand cmd = new SqlCommand(delQry, con);
            cmd.ExecuteNonQuery();
            FillGrid();


        }
        if (e.CommandName == "ed")
        {
            Session["offerid"] = e.CommandArgument.ToString();
            edID = Convert.ToInt32(Session["offerid"].ToString());
            string selQry = "select * from tbl_offer where offer_id='" + edID + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtoffer.Text = dt.Rows[0]["offer_name"].ToString();
            txtfromdate.Text = dt.Rows[0]["offer_fromdate"].ToString();
            txttodate.Text = dt.Rows[0]["offer_todate"].ToString();
            flag = 1;
        }


    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtoffer.Text = "";
        txtfromdate.Text = "";
        txttodate.Text = "";
    }
}