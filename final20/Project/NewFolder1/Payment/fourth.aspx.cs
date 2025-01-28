using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicalInstruments.User.Payment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            if (i == 10)
            {
                i = 0;
                Response.Redirect("fifth.aspx");

            }
        }
    }
}