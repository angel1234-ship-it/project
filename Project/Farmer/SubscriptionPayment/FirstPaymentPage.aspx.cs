﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Farmer_SubscriptionPayment_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    static int farmerID,CartID;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {


            Session["cardno"] = TextBox1.Text;
         
            Response.Redirect("SecondPaymentPage.aspx");
            
            

        }
        else
        {
            Label1.Text = "Please accept the Terms & Conditions";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
    }
}