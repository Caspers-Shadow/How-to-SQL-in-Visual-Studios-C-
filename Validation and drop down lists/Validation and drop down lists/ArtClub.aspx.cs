using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation_and_drop_down_lists
{
    public partial class ArtClub : System.Web.UI.Page
    {

        const decimal NORMAL_COST = 30.00m;
        const decimal RAINBOW_COST = 45.50m;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string name =txtName.Text;
            string surname = txtSurname.Text;
            string colour = ddlColour.SelectedItem.Text;
            int amount ;

            if (!int.TryParse(txtAmount.Text, out amount) && amount > 0)
            {
                lblResult.Text = "Please enter a valid amount.";
            }

            lblResult.Text = "Selections made for " + name + " " + surname + " ---- Colour: " + colour + " - (Amount) " + amount;

            decimal totalCost = 0.0m;

            if (colour == "Rainbow")
            {
                totalCost = amount * RAINBOW_COST;
            }
            else
            {
                totalCost = amount * NORMAL_COST;
            }

            lblAmount.Text = "Total Cost without tax: " + totalCost.ToString("C");

            decimal tax = totalCost * 0.06m;

            lblTax.Text = "Total amount of tax: " + tax.ToString("C");

            decimal totalWithTax = totalCost + tax;
            lblTotal.Text = "Total amount with tax: " + totalWithTax.ToString("C2");


        }
    }
}