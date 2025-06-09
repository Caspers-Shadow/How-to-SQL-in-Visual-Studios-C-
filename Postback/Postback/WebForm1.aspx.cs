using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postback
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
            string time;

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
                lblDisplay.Text = "Please select the number of tickets.";
                return;
            }

            if (btnMorning.Enabled)
            {
                time = btnMorning.Text;
            }
            else if (btnMidday.Enabled)
            {
                time = btnMidday.Text;
            }
            else if (btnEvening.Enabled)
            {
                time = btnEvening.Text;
            }
            else
            {
                lblDisplay.Text = "Please select a show time.";
                return;
            }

            lblDisplay.Text = name + "you have booked the show for " + tickets + " people at " + time;

            btnMorning.Enabled = true;
            btnMidday.Enabled = true;   
            btnEvening.Enabled = true;
        }


        //CausesValidation property for all 3 buttons are setto false
        protected void btnMorning_Click(object sender, EventArgs e)
        {
           btnMorning.Enabled = true;
            btnMidday.Enabled = false;
            btnEvening.Enabled = false;
        }

        protected void btnMidday_Click(object sender, EventArgs e)
        {
            btnMorning.Enabled = false;
            btnMidday.Enabled = true;
            btnEvening.Enabled = false;
        }

        protected void btnEvening_Click(object sender, EventArgs e)
        {
            btnMorning.Enabled = false;
            btnMidday.Enabled = false;
            btnEvening.Enabled = true;
        }
    }
}