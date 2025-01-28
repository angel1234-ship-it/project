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
    static int IdNo,OfferPID,eID,flag,ShopID; 
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                fillOffer();
                FillProduct();
                FillGrid();
                txtactualprice.Text = "";
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
            
            
        }
    }

    protected void grdofferproduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdofferproduct.PageIndex = e.NewPageIndex;
    }
    protected void grdofferproduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            Session["offerproductid"]=e.CommandArgument.ToString();
            OfferPID=Convert.ToInt32(Session["offerproductid"].ToString());
            string delQry="delete from tbl_offerproduct where offerproduct_id ='"+OfferPID+"'";
            SqlCommand cmd=new SqlCommand(delQry,con);
            cmd.ExecuteNonQuery();
            FillGrid();
        }
        if(e.CommandName=="ed")
        {
            
             Session["offerproductid"]=e.CommandArgument.ToString();
            eID=Convert.ToInt32(Session["offerproductid"].ToString());
            string selQry="select * from tbl_offerproduct where offerproduct_id='"+eID+"'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            txtofferprice.Text = dt.Rows[0]["offerproduct_price"].ToString();
            flag = 1;
          

        }

    }
    //protected void btnsave_Click(object sender, EventArgs e)
    //{
    ////    if (flag == 1)
    ////    {
    ////        OfferPID = Convert.ToInt32(Session["offerproductid"].ToString());
    ////        string upQry = "update tbl_offerproduct set offerproduct_price='"+txtofferprice.Text+ " where offerproduct_id='" + OfferPID+ "'";
    ////        SqlCommand cmd = new SqlCommand(upQry, con);
    ////        cmd.ExecuteNonQuery();
    ////        FillGrid();
    ////        flag = 0;
    ////    }
        
    //        string insQry = "insert into tbl_offerproduct (offer_id,shopproduct_id,offerproduct_price)values('" + ddoffer.SelectedValue + "','" + ddshopproduct.SelectedValue + "','" + txtofferprice.Text + "')";
    //        SqlCommand cmd = new SqlCommand(insQry, con);
    //        cmd.ExecuteNonQuery();
    //        FillGrid();
        
    //}

    protected void fillOffer()
    {
        ShopID = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_offer where shop_id='"+ShopID+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddoffer.DataValueField = "offer_id";
        ddoffer.DataTextField = "offer_name";
        ddoffer.Items.Insert(0, "--select--");
        ddoffer.DataSource = dt;
        ddoffer.DataBind();
        ddoffer.Items.Insert(0, "--select--");


    }
    protected void FillProduct()
    {
        ShopID = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_shopproduct  where shop_id='"+ShopID+"' ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddshopproduct.DataValueField = "shopproduct_id";
        ddshopproduct.DataTextField = "shopproduct_name";
        ddshopproduct.Items.Insert(0, "--select--");
        ddshopproduct.DataSource = dt;
        ddshopproduct.DataBind();
        ddshopproduct.Items.Insert(0, "--select--");

    }
    protected void FillGrid()
    {
        ShopID = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from  tbl_offer o inner join tbl_offerproduct op on o.offer_id=op.offer_id  inner join tbl_shopproduct sp on op.shopproduct_id=sp.shopproduct_id where o.shop_id='"+ShopID+"'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdofferproduct.DataSource = dt;
        grdofferproduct.DataBind();


    }

    protected void ddshopproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        IdNo = Convert.ToInt32(ddshopproduct.SelectedValue.ToString());
        string selQry = "select * from tbl_shopproduct where shopproduct_id='" + IdNo + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        txtactualprice.Text = dt.Rows[0]["shopproduct_price"].ToString();

    }
    protected void btnsave_Click1(object sender, EventArgs e)
    {
        if (flag == 1)
        {
            OfferPID = Convert.ToInt32(Session["offerproductid"].ToString());
            string upQry = "update tbl_offerproduct set offerproduct_price='" + txtofferprice.Text + "' where offerproduct_id='" + OfferPID + "'";
            SqlCommand cmd = new SqlCommand(upQry, con);
            cmd.ExecuteNonQuery();
            FillGrid();
            flag = 0;
            FillGrid();
        }
        else
        {
            string insQry = "insert into tbl_offerproduct (offer_id,shopproduct_id,offerproduct_price)values('" + ddoffer.SelectedValue + "','" + ddshopproduct.SelectedValue + "','" + txtofferprice.Text + "')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            FillGrid();
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtofferprice.Text = "";
    }
}