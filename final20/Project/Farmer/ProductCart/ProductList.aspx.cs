using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Farmer_ProductCart_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int ShoppId,farmerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            fillType();
            Datalist();
            cartpanel.Visible = false;
            fillComment();
        }

    }
    protected void fillType()
    {
        string selQry = "select * from tbl_type";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddtype.DataValueField = "type_id";
        ddtype.DataTextField = "type_name";
        ddtype.DataSource = dt;
        ddtype.DataBind();
        ddtype.Items.Insert(0, "--select--");
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        fillComment();

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       


    }
    protected void Datalist()
    {
        string selQry = "select * from tbl_type t inner join tbl_subtype st on t.type_id=st.type_id inner join tbl_shopproduct sp on sp.subtype_id=st.subtype_id";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistcart.DataSource = dt;
        datalistcart.DataBind();


    }
    protected void ddtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_type t inner join tbl_subtype st on t.type_id=st.type_id inner join tbl_shopproduct sp on sp.subtype_id=st.subtype_id where t.type_id='" + ddtype.SelectedValue + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        datalistcart.DataSource = dt;
        datalistcart.DataBind();

    }
    protected void btnpost_Click(object sender, EventArgs e)
    {
        ShoppId=Convert.ToInt32(Session["shoppid"].ToString());
        //farmerID=Convert.ToInt32(Session["farmerid"].ToString());

        string insQry="insert into tbl_comment(comment_description,shopproduct_id,farmer_id,comment_date)values('"+txtcomment.Text+"','"+ShoppId+"','"+Session["farmerid"]+"','"+DateTime.Now.ToShortDateString()+"')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        txtcomment.Text = "";
        cartpanel.Visible = true;


    }
    protected void datalistcart_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "com")
        {
            Session["shoppid"] = e.CommandArgument.ToString();
            ShoppId = Convert.ToInt32(Session["shoppid"].ToString());

            cartpanel.Visible = true;
            txtcomment.Focus();
            fillComment();
            
           
        }
        if (e.CommandName == "cart")
        {
            Session["shoppid"] = e.CommandArgument.ToString();
            ShoppId = Convert.ToInt32(Session["shoppid"].ToString());
            Response.Redirect("OrderItem.aspx");
        }
       
    }
    protected void fillComment()
    {
        
            //ShoppId =Convert.ToInt32(Session["shoppid"].ToString());
            string selQry = "select * from tbl_comment c inner join tbl_farmer f on c.farmer_id=f.farmer_id where c.shopproduct_id='" + Session["shoppid"] + "'";
            SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            if (dt.Rows.Count > 0)
            {
                GridView1.Visible = true;
            }

            else
            {
                GridView1.Visible = false;
            }

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        //txtcomment.Text = "";
        cartpanel.Visible = false;
    }
}