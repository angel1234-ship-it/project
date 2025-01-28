using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Admin_Default : System.Web.UI.Page
{
    SqlConnection con=new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int idNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                fillGrid();
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
            
        }
    }
   
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_complaint c inner join tbl_shop s on  c.shop_id=s.shop_id where complaint_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdshop.DataSource = dt;
        grdshop.DataBind();
        
    }


    protected void grdshop_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "reply")
        {
            Session["cid"] = e.CommandArgument.ToString();
            Response.Redirect("ShopComplaintReply.aspx");
        }
    }
    
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        fillGrid();
    }
    protected void fillGrid1(){
        string selQry = "select *  from tbl_complaint c inner join tbl_shop s on c.shop_id=s.shop_id where complaint_status='1'";
        SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
        DataTable dt=new DataTable();
        adp.Fill(dt);
        grdshopsolved.DataSource=dt;
        grdshopsolved.DataBind();
    }


    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        fillGrid1();
    }
}