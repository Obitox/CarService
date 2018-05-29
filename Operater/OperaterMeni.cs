using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operater
{
    public partial class OperaterMeni : Form
    {
        ServisAutomehanikeREF.ServisOperaterClient referenca;
        private int brojac = 0;

        public OperaterMeni()
        {
            InitializeComponent();
            referenca = new ServisAutomehanikeREF.ServisOperaterClient();
            if(referenca.deserijalizujPodatke().Length > 0)
            {
                string[] niz = referenca.deserijalizujPodatke().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbAutomobili.Items.Contains(niz[i]))
                    {
                        lbAutomobili.Items.Add(niz[i]);
                    }
                }
            }
            if(referenca.deserijalizujKorisnike().Length > 0)
            {
                string[] niz = referenca.deserijalizujKorisnike().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbKorisnici.Items.Contains(niz[i]))
                    {
                        lbKorisnici.Items.Add(niz[i]);
                    }
                }
            }
            if(referenca.deserijalizujPopravke().Length > 0)
            {
                string[] niz = referenca.deserijalizujPopravke().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbPopravke.Items.Contains(niz[i]))
                    {
                        lbPopravke.Items.Add(niz[i]);
                    }
                }
            }
        }

        private void btnNapraviAutomobil_Click(object sender, EventArgs e)
        {
            brojac++;
            ServisAutomehanikeREF.Automobil automobil = referenca.napraviAutomobil(new ServisAutomehanikeREF.Automobil() { id = brojac, podaci = txtPodaci.Text, status = cbStatus.Text, korisnicko_ime = txtKorisnik.Text, cena_popravke = nudCenaPopravke.Value, id_popravke = brojac});
            lbAutomobili.Items.Add("id:"+automobil.id + " podaci:"+automobil.podaci + " status:"+automobil.status+" korisnicko ime:"+automobil.korisnicko_ime+" cena popravke:"+nudCenaPopravke.Value.ToString()+ " id popravke:"+automobil.id_popravke);
        }

        private void btnPotvrdiKorisnika_Click(object sender, EventArgs e)
        {
            ServisAutomehanikeREF.Korisnik korisnik = referenca.napraviKorisnika(new ServisAutomehanikeREF.Korisnik() { korisnicko_ime = txtDodajKorisnickoIme.Text, lozinka = txtDodajLozinku.Text });
            lbKorisnici.Items.Add("korisnicko ime:" + korisnik.korisnicko_ime + " lozinka:"+korisnik.lozinka);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool provera = referenca.napraviPopravku(new ServisAutomehanikeREF.Popravka() { id_popravke = (int.Parse(nudIdPopravke.Value.ToString())), deo = txtDeo.Text, cena_dela = (int.Parse(nudCenaDela.Value.ToString())) });
            if (provera)
            {
                lbPopravke.Items.Clear();
                if (referenca.deserijalizujPopravke().Length > 0)
                {
                    string[] niz = referenca.deserijalizujPopravke().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbPopravke.Items.Contains(niz[i]))
                        {
                            lbPopravke.Items.Add(niz[i]);
                        }
                    }
                }
            }
        }

        private void txtAzurirajCenu_Click(object sender, EventArgs e)
        {
            bool provera = referenca.azuriranjeCeneDelova(int.Parse(nudAzurirajPopravku.Value.ToString()), nudNovaCenaDela.Value);
            if (provera)
            {
                lbPopravke.Items.Clear();
                if (referenca.deserijalizujPopravke().Length > 0)
                {
                    string[] niz = referenca.deserijalizujPopravke().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbPopravke.Items.Contains(niz[i]))
                        {
                            lbPopravke.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujPodatke().Length > 0)
                {
                    string[] niz = referenca.deserijalizujPodatke().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbAutomobili.Items.Contains(niz[i]))
                        {
                            lbAutomobili.Items.Add(niz[i]);
                        }
                    }
                }

            }
        }
    }
}
