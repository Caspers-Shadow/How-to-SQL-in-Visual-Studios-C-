using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_June_Exam_Practice
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie _userInfo = Request.Cookies["UserInfo"];

            if (_userInfo == null)
            {
                lblWelcome.Text = "Welcome guest";
            }
            else
            {
                lblWelcome.Text = "Welcome " + _userInfo["Name"] + " " + _userInfo["Surname"];

            }

               
            lblZone.Text = "Your current zone is: " + Session["Zone"];

            theCal.SelectedDate = theCal.TodaysDate;    
            
            Schedule();

        }

        private void Schedule()
        {
            string timesShed;

            if (Session["Zone"] == "Zone 1")
            {
                timesShed = "06:00-08:30, 12:00-14:30";

                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Monday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Thursday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else if (Session["Zone"] == "Zone 2")
            {
                timesShed = "09:00-11:30, 15:00-17:30";
                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Tuesday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Friday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else if (Session["Zone"] == "Zone 3")
            {
                timesShed = "18:00-20:30, 00:00-02:30";
                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Wednesday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else if (Session["Zone"] == "Zone 4")
            {
                timesShed = "21:00-23:30, 03:00-05:30";
                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Sunday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Wednesday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else if (Session["Zone"] == "Zone 5")
            {
                timesShed = "07:00-09:30, 13:00-15:30";
                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Monday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else if (Session["Zone"] == "Zone 6")
            {
                timesShed = "10:00-12:30, 16:00-18:00";
                if (theCal.SelectedDate.DayOfWeek == DayOfWeek.Tuesday || theCal.SelectedDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    timesShed = "No Load Shedding";
                }
            }
            else
            {
                timesShed = "No Load Shedding for this zone.";
            }

            lblTimes.Text = timesShed;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void theCal_SelectionChanged(object sender, EventArgs e)
        {


            if (theCal.SelectedDate < DateTime.Today)
            {
                lblTimes.Text = "Please select a valid date.";
                return;
            }

            Schedule();

        }
    }
}