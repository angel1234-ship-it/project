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
    SqlConnection con =new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int  IdNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
            string adminID = Session["adminid"].ToString();
            if (adminID != null)
            {
                IdNo = Convert.ToInt32(Session["cid"].ToString());
                string selQry = "select * from tbl_complaint c inner join tbl_shop s on c.shop_id=s.shop_id where complaint_id='" + IdNo + "'";
                SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                txtname.Text = dt.Rows[0]["shop_name"].ToString();
                txttitle.Text = dt.Rows[0]["complaint_title"].ToString();
                txtcomplaint.Text = dt.Rows[0]["complaint_content"].ToString();
            }
            else
            {
                Response.Redirect("../Guest/Login.aspx");
            }
           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string upQry="update tbl_complaint set complaint_reply='"+txtreply.Text+"',complaint_replydate='"+DateTime.Now.ToShortDateString()+"',complaint_status='1' where complaint_id='"+IdNo+"'";
        SqlCommand cmd = new SqlCommand(upQry,con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Reply  Successfully Send')</script>");
        txtreply.Text = "";
    }
}