using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAKS
{
    public partial class Posledna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Ime"] != null)
                {
                    string ime = Session["Ime"].ToString();
                    lblIme.Text = ime;
                }
                if (Session["Prezime"] != null)
                {
                    string prezime = Session["Prezime"].ToString();
                    lblPrezime.Text = prezime;
                }
                if (Session["TelefonskiBroj"] != null)
                {
                    string telefon = Session["TelefonskiBroj"].ToString();
                    lblBroj.Text = telefon;
                }
                if (Session["Email"] != null)
                {
                    string email = Session["Email"].ToString();
                    lblEmail.Text = email;
                }

                if (Session["polozeni"] != null)
                {
                    ArrayList lista = (ArrayList)Session["polozeni"];
                    var vk = 0;
                    foreach (ListItem item in lista)
                    {
                        vk += Convert.ToInt32(item.Value);
                    }

                    lblKrediti.Text =  vk.ToString();

               }
            }
        }

    }
}