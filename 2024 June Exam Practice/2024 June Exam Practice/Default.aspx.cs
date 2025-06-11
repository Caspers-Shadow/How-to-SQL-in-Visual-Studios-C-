using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2024_June_Exam_Practice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie _userInfo = new HttpCookie("UserInfo");

            _userInfo["Name"] = txtName.Text;
            _userInfo["Surname"] = txtSurname.Text;
            _userInfo["Email"] = txtEmail.Text;

            Response.Cookies.Add(_userInfo);

            if (rdoZone1.Checked)
            {
                Session["Zone"] = "Zone 1";
            }
            else if (rdoZone2.Checked)
            {
                Session["Zone"] = "Zone 2";
            }
            else if (rdoZone3.Checked)
            {
                Session["Zone"] = "Zone 3";
            }
            else if (rdoZone4.Checked)
            {
                Session["Zone"] = "Zone 4";
            }
            else if (rdoZone5.Checked)
            {
                Session["Zone"] = "Zone 5";
            }
            else if (rdoZone6.Checked)
            {
                Session["Zone"] = "Zone 6";
            }
            else
            {
                Session["Zone"] = "No Zone Selected";
                return;
            }

            Response.Redirect("Info.aspx");
        }
    }
}