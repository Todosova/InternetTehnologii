using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbPredmeti.Items.Add(new ListItem("Интернет технологии"));
                lbPredmeti.Items.Add(new ListItem("Интернет"));
                lbPredmeti.Items.Add(new ListItem("Дигитална Електроника"));

                lbKrediti.Items.Add(new ListItem("6"));
                lbKrediti.Items.Add(new ListItem("5.5"));
                lbKrediti.Items.Add(new ListItem("5.5"));
            }

        }
        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPredmet = lbPredmeti.SelectedItem.Text;

           
            if (selectedPredmet == "Интернет технологии")
            {
                lblProfesor.Text = "Проф. Д-р Гоце Арменски и Проф. Д-р Магдалена Костоска";
            }
            else if (selectedPredmet == "Интернет")
            {
                lblProfesor.Text = "Проф. Д-р Гоце Арменски";
            }
            else if (selectedPredmet == "Дигитална Електроника")
            {
                lblProfesor.Text = "Проф. Д-р Магдалена Костоска";
            }
            else
            {
                lblProfesor.Text = string.Empty;
            }
        }



        protected void Dodadi_Click(object sender, EventArgs e)
        {
           if(Predmet.Text.Length != 0 && Krediti.Text.Length!=0)
            {
                lbPredmeti.Items.Add(new ListItem(Predmet.Text));
                lbKrediti.Items.Add((new ListItem(Krediti.Text)));

                Predmet.Text = "";
                Krediti.Text = "";
            }
        }

        protected void Izbrishi_Click(object sender, EventArgs e)
        {
            if(lbPredmeti.SelectedIndex != -1)
            {
                int selectedIndex = lbPredmeti.SelectedIndex;
                lbPredmeti.Items.RemoveAt(selectedIndex);
               lbKrediti.Items.RemoveAt(selectedIndex);
            }
        }
        protected void GlasajBtn_Click(object sender, EventArgs e)
        {
            if (lbPredmeti.SelectedIndex != -1)
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        
    }
    }