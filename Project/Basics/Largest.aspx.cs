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
    protected void btnlarger_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = Convert.ToInt32(txtnumber3.Text);
        if (a > b)
        {
            if (a > c)
            {
                lblresult.Text = a.ToString();
            }
            else
            {
                lblresult.Text = c.ToString();

            }
        }
        else
        {
            if (b > c)
            {
                lblresult.Text = b.ToString();
            }
            else
            {
                lblresult.Text = c.ToString();

            }
        }
    }
    protected void btnsmallest_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Convert.ToInt32(txtnumber1.Text);
        b = Convert.ToInt32(txtnumber2.Text);
        c = Convert.ToInt32(txtnumber3.Text);
        if (a < b)
        {
            if (a < c)
            {
                lblresult.Text = a.ToString();

            }
            else
            {
                lblresult.Text = c.ToString();
            }
        }
        else
        {
            if (b < c)
            {
                lblresult.Text = b.ToString();
            }
            else
            {
                lblresult.Text = c.ToString();
            }

        }
    }
}
