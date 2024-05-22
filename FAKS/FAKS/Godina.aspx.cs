using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAKS
{
    public partial class Godina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void prva_Click(object sender, EventArgs e)
        {
            Response.Redirect("Predmeti.aspx?id=1&naslov=Прва+година");
        }

        protected void vtora_Click(object sender, EventArgs e)
        {
            Response.Redirect("Predmeti.aspx?id=2&naslov=Втора+година");
        }

        protected void treta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Predmeti.aspx?id=3&naslov=Трета+година");
        }

        protected void chetvrta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Predmeti.aspx?id=4&naslov=Четврта+година");
        }
    }
}