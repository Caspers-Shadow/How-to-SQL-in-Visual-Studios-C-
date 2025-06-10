using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender_Control
{
    public partial class Scheduler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            theCal.SelectedDate = DateTime.Today.Date;
        }

        protected void theCal_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = theCal.SelectedDate;

            if (selectedDate < theCal.TodaysDate)
            {
                lblError.Visible = true;
                return;
            }

            string module = txtModule.Text;

            if (string.IsNullOrEmpty(module))
            {
                lblError.Text = "Please enter a module name.";
                lblError.Visible = true;
                return;
            }

            lstOutput.Items.Add(module + " - " + selectedDate.ToString("dddd, yyyy/MM/dd"));
            txtModule.Text = string.Empty;
        }
    }
}