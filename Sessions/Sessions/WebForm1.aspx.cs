using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int tickets = 0;

            if (rdoOne.Checked)
            { 
                tickets = 1;
            }
            else if (rdoTwo.Checked)
            {
                tickets = 2;
            }
            else if (rdoThree.Checked)
            {
                tickets = 3;
            }
            else 
            {
                lblDisplay.Text = "Please select the number of tickets you want to book.";
            }

            lblDisplay.Text = name + " you have a successfully booked the show for " + tickets + " poeple at " + Session["ShowTime"];
        }

        protected void btnMorning_Click(object sender, EventArgs e)
        {
            Session["ShowTime"] = btnMorning.Text;
        }

        protected void btnMidday_Click(object sender, EventArgs e)
        {
            Session["ShowTime"] = btnMidday.Text;

        }

        protected void btnEvening_Click(object sender, EventArgs e)
        {
            Session["ShowTime"] = btnEvening.Text;

        }
    }
}