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
    protected void txtnumber_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnsum_Click(object sender, EventArgs e)
    {
        int num, sum = 0, digit = 0;
        num = Convert.ToInt32(txtnumber.Text);
        while (num > 0)
        {
            digit = num % 10;
            sum = sum + digit;
            num = num / 10;

        }
        lblresult.Text = sum.ToString();
    }
    protected void btnreverse_Click(object sender, EventArgs e)
    {

        int num, rev = 0, digit = 0;
        num = Convert.ToInt32(txtnumber.Text);
        while (num > 0)
        {
            digit = num % 10;
            rev = rev * 10 + digit;
            num = num / 10;

        }
        lblresult.Text = rev.ToString();

    }
    protected void btnpalindrome_Click(object sender, EventArgs e)
    {
        int num, rev = 0, digit = 0, temp;
        num = Convert.ToInt32(txtnumber.Text);
        temp = num;
        while (num > 0)
        {
            digit = num % 10;
            rev = rev * 10 + digit;
            num = num / 10;
        }
        if (temp == rev)
        {

            lblresult.Text = "Palindrome";
        }
        else
        {
            lblresult.Text = "Not palindrome";
        }


    }
}