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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string fname, lname, gender, dept, marital,fullname;
        int basic;
        double netsalary, pf, lic, ta, da, hra, deduct;
        fname = Convert.ToString(txtfname.Text);
        lname = Convert.ToString(txtfname.Text);
        gender = Convert.ToString(rbGender.SelectedValue);
        marital = Convert.ToString(rbMarital.SelectedValue);
        dept = Convert.ToString(ddDept.SelectedValue);
        basic = Convert.ToInt32(txtbasic.Text);
        fullname = txtfname.Text + "  " + txtlname.Text;
        lblgender.Text = gender.ToString();
        lblmarital.Text = marital.ToString();
        lbldept.Text = dept.ToString();
        if (gender == "Female")
        {
            if (marital == "Single")
            {
                lblname.Text = "Ms." + fullname.ToString();
            }
            else
            {
                lblname.Text = "Mrs." + fullname.ToString();
            }
        }
            else
            {
                lblname.Text = fullname.ToString();
            }
        
        if (basic >= 25000)
        {
            ta = basic * 0.5;
            lblta.Text = ta.ToString();
            da = basic * 0.4;
            lblda.Text = da.ToString();
            hra = basic * 0.35;
            lblhra.Text = hra.ToString();
            lic = basic * 0.3;
            lbllic.Text = lic.ToString();
            pf = basic * 0.2;
            lblpf.Text = pf.ToString();
            deduct = lic - pf;
            netsalary = basic + ta + da + hra - deduct;
            lblnetsalary.Text = netsalary.ToString();
        }
        else if (basic >= 20000)
        {
            ta = basic * 0.4;
            lblta.Text = ta.ToString();
            da = basic * 0.3;
            lblda.Text = da.ToString();
            hra = basic * 0.25;
            lblhra.Text = hra.ToString();
            lic = basic * 0.2;
            lbllic.Text = lic.ToString();
            pf = basic * 0.1;
            lblpf.Text = pf.ToString();
            deduct = lic - pf;
            netsalary = basic + ta + da + hra - deduct;
            lblnetsalary.Text = netsalary.ToString();
        }
        else if (basic < 20000)
        {
            ta = basic * 0.3;
            lblta.Text = ta.ToString();
            da = basic * 0.2;
            lblda.Text = da.ToString();
            hra = basic * 0.15;
            lblhra.Text = hra.ToString();
            lic = basic * 0.15;
            lbllic.Text = lic.ToString();
            pf = basic * 0.1;
            lblpf.Text = pf.ToString();
            deduct = lic - pf;
            netsalary = basic + ta + da + hra - deduct;
            lblnetsalary.Text = netsalary.ToString();

        }


        
    }
}