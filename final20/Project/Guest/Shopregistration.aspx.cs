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
        fileProof.SaveAs(Server.MapPath("../Assests/ShopDocs/" + proofName));
        string filephoto = Path.GetFileName(fileimage.PostedFile.FileName.ToString());
        fileimage.SaveAs(Server.MapPath("../Assests/ShopDocs/" + filephoto));

        string insQry = "insert into tbl_shop(shop_name,shop_ownername,place_id,shop_email,shop_contact,shop_username,shop_password,shop_confirmpassword,shop_address,shop_photo,shop_proof,shop_regdate,shop_pincode,shop_securityqns,shop_securityans)values('" + txtshopname.Text + "','" + txtownername.Text + "' ,'" + ddplace.SelectedValue + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtconfirmpassword.Text + "','" + txtaddress.Text + "','" + filephoto + "','" + proofName + "','" + DateTime.Now.ToShortDateString() + "','" + txtpin.Text + "','"+ddshop.SelectedValue+"','"+txtanswers.Text+"')";
        SqlCommand cmd = new SqlCommand(insQry, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Your Registration Successfull')</script>");
        txtshopname.Text = "";
        txtownername.Text = "";
        txtemail.Text = "";
        txtcontact.Text = "";
        txtaddress.Text = "";
        txtanswers.Text = "";
        txtconfirmpassword.Text = "";
        txtpassword.Text = "";
        txtpin.Text = "";
        txtusername.Text = "";
        dddistrict.Text = "--select--";
        ddplace.Text = "--select--";
        ddshop.Text = "--select--";
     
        
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
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_shop where shop_email='" + txtemail.Text + "'";
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
            lbmsg.Text = "Available....";
        }

    }
    protected void txtcontact_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_shop where shop_contact='" + txtcontact.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg1.Text = "Already Exists....";
            txtcontact.Text = "";
        }
        else
        {
            lbmsg1.Text = "Available....";
        }

    }
    protected void txtusername_TextChanged(object sender, EventArgs e)
    {
        string selQry = "select * from tbl_shop where shop_username='" + txtusername.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(selQry, con);
        DataTable dt = new DataTable();
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            lbmsg2.Text = "Already Exists....";
            txtusername.Text = "";
        }
        else
        {
            lbmsg2.Text = "Available....";
        }
    }
    //protected void ddshop_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string insQry = "insert into tbl_shop (shop_securityqns,shop_securityans)values('" + ddshop.SelectedValue + "','" + txtanswers.Text + "')";
    //    SqlCommand cmd = new SqlCommand(insQry, con);
    //    cmd.ExecuteNonQuery();
    //}
}