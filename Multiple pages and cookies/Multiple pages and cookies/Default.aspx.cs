using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiple_pages_and_cookies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rdoNWU_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNWU.Checked)
            {
                Session["University"] = rdoNWU.Text;
            }
            else if (rdoUCT.Checked)
            {
                Session["University"] = rdoUCT.Text;
            }
            else if (rdoUJ.Checked)
            {
                Session["University"] = rdoUJ.Text;
            }
            else if (rdoUOFS.Checked)
            {
                Session["University"] = rdoUOFS.Text;

            }
            else if (rdoUP.Checked)
            {
                Session["University"] = rdoUP.Text;
            }
            else
            {
                Session["University"] = "No university entered";
                return;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie _userInfo = new HttpCookie("UserInfo");

            _userInfo["Name"] = txtName.Text;
            _userInfo["Email"] = txtEmail.Text;

            Response.Cookies.Add(_userInfo);

            Response.Redirect("Info.aspx");
        }
    }
}