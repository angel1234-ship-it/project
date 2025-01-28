using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data.SqlClient;
using System.Data;

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
        fileProof.SaveAs(Server.MapPath("../Assests/AgencyDocs/" + proofName));
        string logoName = Path.GetFileName(fileLogo.PostedFile.FileName.ToString());
        fileLogo.SaveAs(Server.MapPath("../Assests/AgencyDocs/" + logoName));


        string insQry = "insert into tbl_agency(agency_name,place_id,agency_email,agency_contact,agency_username,agency_password,agency_confirmpass,agency_address,agency_proof,agency_logo,agency_regdate,agency_pincode,agency_securityqns,agency_securityans)values('" + txtname.Text + "' ,'" + ddplace.SelectedValue + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtuser.Text + "','" + txtpassword.Text + "','" + txtconfirmpassword.Text + "','" + txtaddress.Text + "','" + proofName + "','" + logoName + "','" + DateTime.Now.ToShortDateString() + "','" + txtpin.Text + "','"+ddsecurity.SelectedValue+"','"+txtsecurity.Text+"')";
            SqlCommand cmd = new SqlCommand(insQry, con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Your Registration Successfull')</script>");
            txtname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtpin.Text = "";
            txtuser.Text = "";
            txtsecurity.Text = "";
            txtpassword.Text = "";
            txtconfirmpassword.Text = "";
            ddplace.Text = "--select--";
            dddistrict.Text = "--select--";
            ddsecurity.Text = "--select--";      
     
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
    protected void fillPlace()
    {
       
    }



    protected void dddistrict_SelectedIndexChanged(object sender, EventArgs e)
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
    protected void txtcontact_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_agency where agency_contact='" + txtcontact + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg.Text = "Already Exists....";
            txtcontact.Text = "";
        }
        else
        {
            lbmsg.Text = "Available....";
        }
    }
    protected void txtuser_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_agency where agency_username='"+txtuser.Text+ "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg1.Text = "Already Exists....";
            txtuser.Text = "";
        }
        else
        {
            lbmsg1.Text = "Available....";
        }

    }

    
    protected void txtemail_TextChanged1(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_agency where agency_email='" + txtemail.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg2.Text = "Already Exists....";
            txtemail.Text = "";
        }
        else
        {
            lbmsg2.Text = "Available....";
        }
    }
    //protected void ddsecurity_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string insQry = "insert into tbl_agency (agency_securityqns,agency_securityans)values('" + ddsecurity.Text + "','" + txtsecurity.Text + "')";
    //    SqlCommand cmd = new SqlCommand(insQry, con);
    //    cmd.ExecuteNonQuery();

    //}
}