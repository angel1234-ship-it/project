﻿using System;
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
    static int IdNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                DetailsView();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }

           
        }

    }
    protected void DetailsView(){
        IdNo=Convert.ToInt32(Session["adminid"].ToString());
        string selQry = "select * from tbl_admin where admin_id='" + IdNo + "'";
        SqlDataAdapter adp=new SqlDataAdapter(selQry,con);
        DataTable dt=new DataTable();
        adp.Fill(dt);
        dvadmin.DataSource=dt;
        dvadmin.DataBind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}