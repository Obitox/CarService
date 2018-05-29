using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Klijent
{
    public partial class View : System.Web.UI.Page
    {
        ServisAutomehanikeREFER.ServisKlijentClient referenca;
        public static string korisnik = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            referenca = new ServisAutomehanikeREFER.ServisKlijentClient();
        }

        protected void On_Click(object sender, EventArgs e)
        {
            bool provera = referenca.prijavljivanjeKlijenta(korisnickoime.Text, lozinka.Text);

            if (provera)
            {
                korisnik = korisnickoime.Text;
                Response.Redirect("KlijentMeni.aspx");
            }
            else
            {
                Msg.Text = "Podaci nisu tacni!";
            }
        }
    }
}