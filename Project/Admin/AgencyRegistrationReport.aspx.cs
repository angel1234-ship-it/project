using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;





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
                fillGrid1();
                fillsub();
                
                
        
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }

          
        }
    }
    

    protected void btnsearch_Click1(object sender, EventArgs e)
    {
        //string selQry = "select * from tbl_agency where  agency_regdate between '" + txtdate.Text + "' and '" + txttodate.Text + "' ";
        //SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        //DataTable dt = new DataTable();
        //adp.Fill(dt);
        //if (dt.Rows.Count > 0)
        //{
        //    Literalsearch.Text = "<table border='1' >";
        //    Literalsearch.Text += "<tr><td><b>Registration ID</b></td>";
        //    Literalsearch.Text += "<td><b>Agency Name</b></td>";
        //    Literalsearch.Text += "<td><b>Address</b></td>";
        //    Literalsearch.Text += "<td><b>Email</b></td>";
        //    Literalsearch.Text += "<td><b>Contact</b></td>";
        //    Literalsearch.Text += "<td><b>Registartion Date</b></td></tr>";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {

        //        Literalsearch.Text += "<tr><td>" + dt.Rows[i]["agency_id"].ToString() + "</td>";
        //        Literalsearch.Text += "<td>" + dt.Rows[i]["agency_name"].ToString() + "</td>";
        //        Literalsearch.Text += "<td>" + dt.Rows[i]["agency_address"].ToString() + "</td>";
        //        Literalsearch.Text += "<td>" + dt.Rows[i]["agency_email"].ToString() + "</td>";
        //        Literalsearch.Text += "<td>" + dt.Rows[i]["agency_contact"].ToString() + "</td>";
        //        Literalsearch.Text += "<td>" + dt.Rows[i]["agency_regdate"].ToString() + "</td></tr>";
        //    }
        //    Literalsearch.Text += "</table>";
        //}
        //else
        //{
        //    Literalsearch.Text = "No such record ";
        //}
        fillAgency();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void btnsearch1_Click(object sender, EventArgs e)
    {
        fillGrid();

      


    }
    protected void grdsubscription_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdsubscription.PageIndex = e.NewPageIndex;
        fillGrid();
        
    }
    protected void fillGrid()
    {

        string selQry = "select * from tbl_agency  a inner join tbl_subscriptionpayment s on a.agency_id=s.agency_id where  s.subpayment_date between '" + txtdate1.Text + "' and '" + txttodate1.Text + "' and s.subpayment_status='1' ";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        grdsubscription.DataSource = dt;
        grdsubscription.DataBind();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
 
 
protected void LinkButton3_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 2;
    fillGrid1();
 
 
   
}


protected void grdfarmer1_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
    grdfarmer1.PageIndex = e.NewPageIndex;
    fillGrid1();
}
protected void fillGrid1()
{

    string selQry = "select * from tbl_farmer where  farmer_regdate between '" + txtdate2.Text + "' and '" + txttodate2.Text + "' ";
    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    DataTable dt = new DataTable();
    adp.Fill(dt);
    grdfarmer1.DataSource = dt;
    grdfarmer1.DataBind();
}

protected void btnsearch2_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 2;
    fillGrid1();
}
protected void grdsubview_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
    grdsubview.PageIndex = e.NewPageIndex;
    fillsub();

}
protected void btnsearch4_Click(object sender, EventArgs e)
{
    fillsub();

}
protected void fillsub()
{
    string selQry = "select * from tbl_farmer  f inner join tbl_subscriptionpayment s on f.farmer_id=s.farmer_id where  s.subpayment_date between '" + txtdate3.Text + "' and '" + txttodate3.Text + "' and s.subpayment_status='1' ";
    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    DataTable dt = new DataTable();
    adp.Fill(dt);
    grdsubview.DataSource = dt;
    grdsubview.DataBind();


}
protected void LinkButton4_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 3;
   
}
protected void btnshopreport_Click(object sender, EventArgs e)
{
    fillshop();
}
protected void grdshopreg_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
    grdshopreg.PageIndex = e.NewPageIndex;
    fillshop();
}

protected void fillshop()
{
    string selQry = "select * from tbl_shop where  shop_regdate between '" + txtshopfdate.Text + "' and '" + txtshoptdate.Text + "' ";
    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    DataTable dt = new DataTable();
    adp.Fill(dt);
    grdshopreg.DataSource = dt;
    grdshopreg.DataBind();

}
protected void LinkButton5_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 4;
}
protected void grdsubshop_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
    grdsubshop.PageIndex = e.NewPageIndex;
    fillshopSub();

}
protected void btnfinalreport_Click(object sender, EventArgs e)
{
    fillshopSub();
}
protected void fillshopSub()
{
    string selQry = "select * from tbl_shop  sp inner join tbl_subscriptionpayment s on sp.shop_id=s.shop_id where  s.subpayment_date between '" + txtshopdatef.Text + "' and '" + txtshopdatet.Text + "' and s.subpayment_status='1' ";
    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    DataTable dt = new DataTable();
    adp.Fill(dt);
    grdsubshop.DataSource = dt;
    grdsubshop.DataBind();

}
protected void LinkButton6_Click(object sender, EventArgs e)
{
    MultiView1.ActiveViewIndex = 5;
}


protected void Button1_Click(object sender, EventArgs e)
{
//    protected void btnPrint_Click(object sender, EventArgs e)
//{
    //ScriptManager.RegisterStartupScript(this, typeof(Page), "PrintGridView", "printGridView();", true);
//}
}
//protected void btnnew_Click(object sender, EventArgs e)
//{
//    ScriptManager.RegisterStartupScript(this, typeof(Page), "PrintGridView", "printGridView();", true);
//}
//protected void btnPrint_Click(object sender, EventArgs e)
//{
    
//    ScriptManager.RegisterStartupScript(this, typeof(Page), "PrintGridView", "printGridView();", true);
  
//}
//protected void grdagency_PageIndexChanging(object sender, GridViewPageEventArgs e)
//{
//    grdagency.PageIndex = e.NewPageIndex;
//    fillAgency();

//}
protected void fillAgency()
{
    string selQry = "select * from tbl_agency where  agency_regdate between '" + txtdate.Text + "' and '" + txttodate.Text + "' ";
    SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
    DataTable dt = new DataTable();
    adp.Fill(dt);
    grdagency.DataSource = dt;
    grdagency.DataBind();


}
//protected void btnprintnew_Click(object sender, EventArgs e)
//{
//    ScriptManager.RegisterStartupScript(this, typeof(Page), "PrintGridView", "printGridView();", true);
//}
protected void grdfarmer1_SelectedIndexChanged(object sender, EventArgs e)
{
    
}
}
