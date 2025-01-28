using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class Guest_Default : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-1P4VELIR;Initial Catalog=db_pinapplefarm;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (!IsPostBack)
        {
         
            fillDistrict();
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string proofName = Path.GetFileName(fileProof.PostedFile.FileName.ToString());
        fileProof.SaveAs(Server.MapPath("../Assests/FarmerDocs/" + proofName));
        string filephoto = Path.GetFileName(Fileimage.PostedFile.FileName.ToString());
        Fileimage.SaveAs(Server.MapPath("../Assests/FarmerDocs/" + filephoto));
        string insQry = "insert into tbl_farmer(farmer_name,farmer_address,place_id,farmer_pin,farmer_email,farmer_contact,farmer_username,farmer_password,farmer_confirmpassword,farmer_photo,farmer_proof,farmer_regdate,farmer_securityqns,farmer_securityans)values('" + txtname.Text + "','" + txtaddress.Text + "','" + ddplace.SelectedValue + "' ,'" + txtpin.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtconfirmpassword.Text + "','" + filephoto + "','" + proofName + "','" + DateTime.Now.ToShortDateString() + "','"+ddsecurityfarmer.SelectedValue+"','"+txtanswer.Text+"')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Registration Successfull')</script>");
            txtname.Text = "";
            txtaddress.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtpin.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconfirmpassword.Text = "";
            txtanswer.Text = "";
            dddistrict.Text = "--select--";
            ddplace.Text = "--select--";
            ddsecurityfarmer.Text = "--select--";                 
    }
    
    
    protected void fillDistrict()
    {
        string selQry = "select * from tbl_district";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        dddistrict.DataSource = dt;
        dddistrict.DataTextField = "district_name";
        dddistrict.DataValueField = "district_id";
        dddistrict.DataBind();
        dddistrict.Items.Insert(0, "--select--");
    }
  
    protected void grdfarmer_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
       

    }
    protected void drddistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_place where district_id='" + dddistrict.SelectedValue + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        ddplace.DataSource = dt;
        ddplace.DataTextField = "place_name";
        ddplace.DataValueField = "place_id";
        ddplace.DataBind();
        ddplace.Items.Insert(0, "--select--");
    }

    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_farmer where farmer_email='" +txtemail.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg.Text = "Already Exists....";
            txtemail.Text = "";

        }
        else
        {
            lbmsg.Text = "Available...";
        }
    }
    protected void txtusername_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_farmer where farmer_username='" + txtusername.Text+ "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg1.Text = "Already Exists....";
            txtusername.Text = "";

        }
        else
        {
            lbmsg1.Text = "Available...";
        }

    }
    protected void txtcontact_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_farmer where farmer_contact='" +txtcontact.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg2.Text = "Already Exists....";
            txtcontact.Text = "";

        }
        else
        {
            lbmsg2.Text = "Available...";
        }
    }
}