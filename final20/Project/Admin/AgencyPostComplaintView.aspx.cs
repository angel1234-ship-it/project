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
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
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
    protected void grdagency_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "reply")
        {
            Session["cid"] = e.CommandArgument.ToString();
            Response.Redirect("AgencyComplaintReply.aspx");
        }

    }
    protected void fillGrid()
    {
        string selQry = "select * from tbl_complaint c inner join tbl_agency a on a.agency_id=c.agency_id where complaint_status='0'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdagency.DataSource = dt;
        grdagency.DataBind();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        fillGrid();
        MultiView1.ActiveViewIndex = 0;

    }
    protected void fillGrid1()
    {
        string selQry = "select * from tbl_complaint c inner join tbl_agency a on a.agency_id=c.agency_id where complaint_status='1'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdagencysolved.DataSource = dt;
        grdagencysolved.DataBind();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        fillGrid1();
        MultiView1.ActiveViewIndex = 1;
    }
}