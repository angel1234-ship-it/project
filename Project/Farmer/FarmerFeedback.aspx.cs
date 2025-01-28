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
    static int FarmerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string farmerID = Session["farmerid"].ToString();
            if (farmerID != null)
            {
                MultiView1.ActiveViewIndex = 1;
                fillGrid();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
          
          
        }
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        FarmerId = Convert.ToInt32(Session["farmerid"].ToString());
        string insQry = "insert into tbl_feedback (feedback_content,feedback_date,farmer_id)values('" + txtfeedback.Text + "','" + DateTime.Now.ToShortDateString() + "','" + FarmerId + "')";
        SqlCommand cmd = new SqlCommand(insQry,con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Feedback Successfully Send')</script>");
       

       
    }
    protected void grdfeedback_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfeedback.PageIndex = e.NewPageIndex;
        fillGrid();

    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfeedback.Text = "";
    }
 
    protected void fillGrid()
    {
        FarmerId = Convert.ToInt32(Session["farmerid"].ToString());
        string selQry = "select * from tbl_feedback where farmer_id='" + FarmerId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfeedback.DataSource = dt;
        grdfeedback.DataBind();

    }
    //protected void btnfeed_Click(object sender, EventArgs e)
    //{
        
    //}
    protected void LinkButtonfeedback_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        fillGrid();

    }
}