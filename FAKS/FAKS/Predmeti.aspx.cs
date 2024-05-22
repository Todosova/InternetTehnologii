using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAKS
{
    public partial class Predmeti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList lista;
            if (Session["polozeni"] != null)
            {
                lista = (ArrayList)Session["polozeni"];
                polozeni.DataSource = lista;
                polozen.DataBind();
            }
        
            if(!IsPostBack)
            {
                string[] prvagodinapredmeti =
                {
                    "Strukturno programiranje",
                    "Kalkulus",
                    "Objektno orientirano programiranje"
                };
                string[] prvagodinakrediti =
                {
                    "6",
                    "7",
                    "6"
                };
                string[] vtoragodinapredmeti =
                {
                    "Internet programiranje na klientska strana",
                    "Internet tehkologii",
                    "Verojatnost i statistika"
                };
                string[] vtoragodinakrediti =
                {
                    "6",
                    "7",
                    "8"
                };
                string[] tretagodinapredmeti =
                {
                    "Dizajn interakcija chovek kompjuter",
                    "VNP",
                    "Veb programiranje"
                };
                string[] tretagodinakrediti =
                {
                    "6",
                    "5",
                    "5"
                };
                string[] chetvrtagodinapredmeti =
                {
                    "upravuvanje so IKT proekti",
                    "Timski proekt",
                    "Diplomsk arabota"
                };
                string[] chetvrtagodinakrediti =
                {
                    "6",
                    "5",
                    "8"
                };
                naslov.Text = Request.QueryString["naslov"];
                int CID = Convert.ToInt32(Request.QueryString["id"]);

                if( CID == 1)
                {
                    Predmeti1.DataSource = prvagodinapredmeti;
                    Krediti.DataSource = prvagodinakrediti;
                }
                else if (CID == 2)
                {
                    Predmeti1.DataSource = vtoragodinapredmeti;
                    Krediti.DataSource = vtoragodinakrediti;
                }
                else if (CID == 3)
                {
                    Predmeti1.DataSource = tretagodinapredmeti;
                    Krediti.DataSource = tretagodinakrediti;
                }
                else if (CID == 4)
                {
                    Predmeti1.DataSource = chetvrtagodinapredmeti;
                    Krediti.DataSource = chetvrtagodinakrediti;
                }

                Predmeti1.DataBind();
                Krediti.DataBind();
            }
        }
            protected void Predmeti_SelectedIndexChanged(object sender, EventArgs e)
            {
                Krediti.SelectedIndex = Predmeti1.SelectedIndex;
                if (ViewState["totalID"] == null)
                {
                    ViewState["totalID"] = 1;
                }
                else
                {
                    ViewState["totalID"] = (int)ViewState["totalID"] + 1;
                    totalID.Text = ((int)ViewState["totalID"]).ToString();
                }
            }
        protected void Dodadi_Click(object sender, EventArgs e)
        {
            if(dodadiPredmet.Text.Length !=0 && dodadiKredit.Text.Length != 0 )
            {
                Predmeti1.Items.Add(new ListItem(dodadiPredmet.Text));
                Krediti.Items.Add(new ListItem(dodadiKredit.Text));
            }
        }
        protected void Izbrishi_Click(object sender, EventArgs e)
        {
            int selectedindex=Predmeti1.SelectedIndex;
            if(selectedindex != -1 )
            {
                Predmeti1.Items.RemoveAt(selectedindex);
                Krediti.Items.RemoveAt(selectedindex);

            }
        }
           
        protected void polozen_Click(object sender, EventArgs e)
        {
            ArrayList lista;
            if (Session["polozeni"] == null)
            {
                lista = new ArrayList();
            }
            else
            {
                lista = (ArrayList)Session["polozeni"];
            }
            lista.Add(new ListItem(Predmeti1.SelectedItem.Text, Krediti.SelectedItem.Text));
            polozeni.DataSource = lista;
            polozeni.DataBind();
            Session["polozeni"] = lista;
        }

        

        protected void Done_Click(object sender, EventArgs e)
        {
            ArrayList polozeniPredmeti = new ArrayList();
            foreach (ListItem item in polozeni.Items)
            {
                polozeniPredmeti.Add(item.Text);
            }

            Session["PolozeniPredmeti"] = polozeni.Items;
                Session["VkupnoKrediti"] = totalID.Text;
                Response.Redirect("Posledna.aspx");
            

        }
    }
}