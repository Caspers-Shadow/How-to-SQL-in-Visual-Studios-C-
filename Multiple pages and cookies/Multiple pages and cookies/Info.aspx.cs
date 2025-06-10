using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiple_pages_and_cookies
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime startingDate;

            HttpCookie _userStuff = Request.Cookies["UserInfo"];

            if (Session["University"] == "NWU")
            {
                theCal.SelectedDate = new DateTime(2021, 2, 3);
            }
            else if (Session["University"] == "UCT")
            {
                theCal.SelectedDate = new DateTime(2021, 2, 5);
            }
            else if (Session["University"] == "UJ")
            {
                theCal.SelectedDate = new DateTime(2021, 2, 10);
            }
            else if (Session["University"] == "UOFS")
            {
                theCal.SelectedDate = new DateTime(2021, 2, 3);
            }
            else if (Session["University"] == "UP")
            {
                theCal.SelectedDate = new DateTime(2021, 2, 17);
            }
            else
            {
                lblStarting.Text = "No university selected.";
                return;
            }

            lblStarting.Text = "Welcome " + _userStuff["name"] + ", the " + Session["University"] + " starts " + theCal.SelectedDate.ToString("yyyy/MM/dd") ;
            lblEmail.Text = "We will send you a reminder to: " + _userStuff["email"];
            theCal.SelectedDate = DateTime.Today;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}