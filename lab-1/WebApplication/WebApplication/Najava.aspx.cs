using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void najavi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                RequiredName.Visible = true;
            }
            else
            {
                RequiredName.Visible = false;
            }

            if (string.IsNullOrEmpty(password.Text))
            {
                RequiredPassword.Visible = true;
            }
            else
            {
                RequiredPassword.Visible = false;
            }

            if (string.IsNullOrEmpty(email.Text) || !Regex.IsMatch(email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                RequiredEmail.Visible = true;
            }
            else
            {
                RequiredEmail.Visible = false;
            }

            if (!RequiredName.Visible && !RequiredPassword.Visible && !RequiredEmail.Visible)
            {
                Response.Redirect("Glasaj.aspx");
            }
        }

    }
}