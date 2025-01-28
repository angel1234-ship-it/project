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
    static int shopId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string shopID = Session["shopid"].ToString();
            if (shopID != null)
            {
                MultiView1.ActiveViewIndex = 0;
                fillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
         

        }

    }
    protected void grdfeed_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfeed.PageIndex = e.NewPageIndex;
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        shopId = Convert.ToInt32(Session["shopid"].ToString());
        string insQry = "insert into tbl_feedback(feedback_content,feedback_date,shop_id)values('" + txtfeedback.Text + "','" + DateTime.Now.ToShortDateString() + "','" + shopId + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Feedback Successfully Send')</script>");
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfeedback.Text = "";
    }
    //protected void btnfeed_Click(object sender, EventArgs e)
    //{
    //}
    protected void fillGrid()
    {
        shopId = Convert.ToInt32(Session["shopid"].ToString());
        string selQry = "select * from tbl_feedback where shop_id='" + shopId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfeed.DataSource = dt;
        grdfeed.DataBind();
    }
    protected void LinkButtonfeedback_Click(object sender, EventArgs e)
    {

        MultiView1.ActiveViewIndex = 1;
        fillGrid();
    }
}