using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calender_and_image
{
    public partial class Delivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            theCal.SelectedDate = theCal.TodaysDate;
            lblOut.Text = "The item will be delivered:";
        }

        protected void theCal_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = theCal.SelectedDate;
            DateTime delivery;

            if (selectedDate.DayOfWeek == DayOfWeek.Friday || selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                delivery = selectedDate.AddDays(3);
            }
            else 
            {
                delivery = selectedDate.AddDays(2);
            }

            lblOut.Text = "The item will be delivered:\n" + delivery.ToString("dddd, dd MMMM yyyy");

        }
    }
}