using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAKS
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Najavise_Click(object sender, EventArgs e)
        {
            
                Session["Ime"] = name.Text;
                Session["Prezime"] = lastname.Text;
                Session["TelefonskiBroj"] = phone.Text;
                Session["Email"] = email.Text;
                Response.Redirect("Godina.aspx");
            

        }

    }
}