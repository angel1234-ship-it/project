using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Basics_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownDept_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string fname, lname, dept, grade, fullname, gender;
        int m1, m2, m3, total, percentage;
        fname = Convert.ToString(txtfname.Text);
        lname = Convert.ToString(txtlname.Text);
        gender = Convert.ToString(rdbGender.SelectedValue);
        dept = Convert.ToString(ddldept.SelectedValue);
        m1 = Convert.ToInt32(txtm1.Text);
        m2 = Convert.ToInt32(txtm2.Text);
        m3 = Convert.ToInt32(txtm3.Text);
        total = m1 + m2 + m3;
        lbltotal.Text = total.ToString();
        percentage = total * 100 / 300;
        lblpercentage.Text = percentage.ToString()+"%";
        fullname = txtfname.Text + " " + txtlname.Text;
        lblname.Text = fullname.ToString();
        if (gender == "Male")
        {
            lblname.Text = "Mr." + fullname.ToString();
        }
        else
        {
            lblname.Text = "Ms." + fullname.ToString();
        }
        lblgender.Text = gender.ToString();
        lbldep.Text = dept.ToString();
        if (percentage > 90)
        {
            lblgrade.Text = "A+";
        }
        else if (percentage > 80)
        {
            lblgrade.Text = "B+";
        }
        else if (percentage > 70)
        {
            lblgrade.Text = "C+";
        }
        else if (percentage > 60)
        {
            lblgrade.Text = "D+";
        }
        else
        {
            lblgrade.Text = "D";
        }

    }
}