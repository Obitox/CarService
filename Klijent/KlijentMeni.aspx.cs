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
    public partial class KlijentMeni : System.Web.UI.Page
    {
        ServisAutomehanikeREFER.ServisKlijentClient referenca;
        List<string> listaElemenata;

        protected void Page_Init(object sender, EventArgs e)
        {
            referenca = new ServisAutomehanikeREFER.ServisKlijentClient();
            listaElemenata = new List<string>();

            ddlPlacanje.Items.Add("Karticom");
            ddlPlacanje.Items.Add("Gotovinski");

            if (referenca.prikazPodatakaICena(View.korisnik).Length > 0)
            {
                string[] niz = referenca.prikazPodatakaICena(View.korisnik).Split('|');
                var myList = new List<string>();

                foreach (var s in niz)
                {
                    if (!myList.Contains(s))
                        myList.Add(s);
                }
                foreach (string element in myList)
                {
                    lbCeneITroskovi.Items.Add(element);
                    listaElemenata.Add(element);
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Placanje_Click(object sender, EventArgs e)
        {
            foreach (string element in listaElemenata)
            {
                if (ddlPlacanje.SelectedIndex != -1)
                {
                    if (element.Contains("popravljen"))
                    {
                        if (referenca.deserijalizuj(View.korisnik).Length > 0)
                        {
                            string[] niz = referenca.deserijalizuj(View.korisnik).Split('|');
                            var myList = new List<string>();

                            foreach (var s in niz)
                            {
                                if (!myList.Contains(s))
                                    myList.Add(s);
                            }
                            foreach (string x in myList)
                            {
                                lbCeneITroskovi.Items.Add(x);
                                listaElemenata.Add(x);
                            }
                        }
                    }
                    else
                    {
                        lblObavestenja.Text = "Nije popravljen";
                    }
                }
                else
                {
                    lblObavestenja.Text = "Niste odabrali način plaćanja!";
                }
            }
        }

    }
}