using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Agency_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int agencyId, farmerId, shopId;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string agencyID = Session["agencyid"].ToString();
            if (agencyID != null)
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
   
    protected void btnsend_Click1(object sender, EventArgs e)
    {
        
        agencyId = Convert.ToInt32(Session["agencyid"].ToString());
        string insQry = "insert into tbl_feedback (feedback_content,feedback_date,agency_id)values('" + txtfeedback.Text + "','" + DateTime.Now.ToShortDateString() + "','" + agencyId + "')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Feedback Successfully Saved')</script>");
     

    }
    protected void grdfeedback_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdfeedback.PageIndex = e.NewPageIndex;
        fillGrid();
    }
    protected void fillGrid()
    {
        agencyId = Convert.ToInt32(Session["agencyid"].ToString());
        string selQry = "select * from tbl_feedback where agency_id='" + agencyId + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdfeedback.DataSource = dt;
        grdfeedback.DataBind();

    }
    //protected void btnfeedback_Click(object sender, EventArgs e)
    //{
       
    //}
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtfeedback.Text = "";
    }
    protected void linkfeedback_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
        fillGrid();
    }
}