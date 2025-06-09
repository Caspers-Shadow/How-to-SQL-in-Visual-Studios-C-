using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Create_a_wedsite_with_an_event_handler
{
    public partial class ToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newItem = txtItems.Text;

            if (!string.IsNullOrEmpty(newItem))
            {
                lstList.Items.Add(newItem);
            }
            else
            {
                Message.Text = "Please enter an item to add to the list.";
                return;
            }

            
            txtItems.Text = string.Empty;
        }

        protected void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string removing = lstList.SelectedItem.Text;

            if (!string.IsNullOrEmpty(name))
            {
                Message.Text = name + ", " + removing + " removed from the list.";
                lstList.Items.Remove(lstList.SelectedItem);
            }
            else
            {
                Message.Text = "Please enter your name to confirm removal.";
                return;
            }

        }
    }
}