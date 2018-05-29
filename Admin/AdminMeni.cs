using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class AdminMeni : Form
    {
        ServisAutomehanikeref.ServisAdminClient referenca;
        int brojac = 50;

        public AdminMeni()
        {
            InitializeComponent();
            referenca = new ServisAutomehanikeref.ServisAdminClient();
            if (referenca.deserijalizujKorisnikeAdmin().Length > 0)
            {
                string[] niz = referenca.deserijalizujKorisnikeAdmin().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbKorisnici.Items.Contains(niz[i]))
                    {
                        lbKorisnici.Items.Add(niz[i]);
                    }
                }
            }
            if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
            {
                string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbAutomobili.Items.Contains(niz[i]))
                    {
                        lbAutomobili.Items.Add(niz[i]);
                    }
                }
            }
            if (referenca.deserijalizujPopravkuAzuriranje().Length > 0)
            {
                string[] niz = referenca.deserijalizujPopravkuAzuriranje().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbPopravke.Items.Contains(niz[i]))
                    {
                        lbPopravke.Items.Add(niz[i]);
                    }
                }
            }
        }

        private void btnPotvrdiKorisnika_Click(object sender, EventArgs e)
        {
            ServisAutomehanikeref.Korisnik korisnik = referenca.kreirajKorisnika(new ServisAutomehanikeref.Korisnik() { korisnicko_ime = txtDodajKorisnickoIme.Text, lozinka = txtDodajLozinku.Text });
            lbKorisnici.Items.Add("Korisnicko ime:"+korisnik.korisnicko_ime + " Lozinka:"+korisnik.lozinka);
            if (referenca.deserijalizujKorisnikeAdmin().Length > 0)
            {
                lbKorisnici.Items.Clear();
                string[] niz = referenca.deserijalizujKorisnikeAdmin().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbKorisnici.Items.Contains(niz[i]))
                    {
                        lbKorisnici.Items.Add(niz[i]);
                    }
                }
            }
            if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
            {
                lbAutomobili.Items.Clear();
                string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

                for (int i = 0; i < niz.Length; i++)
                {
                    if (!lbAutomobili.Items.Contains(niz[i]))
                    {
                        lbAutomobili.Items.Add(niz[i]);
                    }
                }
            }
        }

        private void btnIzbrisiKorisnika_Click(object sender, EventArgs e)
        {
            bool provera = referenca.izbrisiKorisnika(txtIzbrisiKorisnickoIme.Text);
            if (provera)
            {
                lbKorisnici.Items.Clear();
                if (referenca.deserijalizujKorisnikeAdmin().Length > 0)
                {
                    string[] niz = referenca.deserijalizujKorisnikeAdmin().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbKorisnici.Items.Contains(niz[i]))
                        {
                            lbKorisnici.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
                {
                    lbAutomobili.Items.Clear();
                    string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

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

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            bool provera = referenca.AzurirajKorisnika(txtKorisnikZaAzuiranje.Text, txtAzurirajKorisnickoIme.Text, txtAzurirajLozinku.Text);
            if (provera)
            {
                if (referenca.deserijalizujKorisnikeAdmin().Length > 0)
                {
                    string[] niz = referenca.deserijalizujKorisnikeAdmin().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbKorisnici.Items.Contains(niz[i]))
                        {
                            lbKorisnici.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
                {
                    lbAutomobili.Items.Clear();
                    string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

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

        private void btnNapraviAutomobil_Click(object sender, EventArgs e)
        {
            brojac++;
            ServisAutomehanikeref.Automobil automobil = referenca.kreirajAutomobil(new ServisAutomehanikeref.Automobil() { id = brojac, podaci = txtPodaci.Text, status = cbStatus.Text, korisnicko_ime = txtKorisnik.Text, cena_popravke = nudCenaPopravke.Value, id_popravke = brojac });
            lbAutomobili.Items.Add("id:" + automobil.id + " podaci:" + automobil.podaci + " status:" + automobil.status + " korisnicko ime:" + automobil.korisnicko_ime + " cena popravke:" + nudCenaPopravke.Value.ToString() + " id popravke:" + automobil.id_popravke);
        }

        private void btnObrisiAutomobil_Click(object sender, EventArgs e)
        {
            bool provera = referenca.izbrisiAutomobil(int.Parse(nudIdAutomobila.Value.ToString()));
            if (provera)
            {
                if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
                {
                    lbAutomobili.Items.Clear();

                    string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbAutomobili.Items.Contains(niz[i]))
                        {
                            lbAutomobili.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujPopravkuAzuriranje().Length > 0)
                {
                    lbPopravke.Items.Clear();

                    string[] niz = referenca.deserijalizujPopravkuAzuriranje().Split('|');

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

        private void btnAutomobilAzuriranje_Click(object sender, EventArgs e)
        {
            bool provera = referenca.azurirajAutomobil(int.Parse(nudIdAutomobilaAzuriranje.Value.ToString()), txtPodaciAzuriranje.Text, cbStatusAzuriranje.Text, txtKorisnickoImeAzuriranje.Text, nudCenaTroskovaAzuriranje.Value);
            if (provera)
            {
                if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
                {
                    lbAutomobili.Items.Clear();

                    string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbAutomobili.Items.Contains(niz[i]))
                        {
                            lbAutomobili.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujPopravkuAzuriranje().Length > 0)
                {
                    lbPopravke.Items.Clear();

                    string[] niz = referenca.deserijalizujPopravkuAzuriranje().Split('|');

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

        private void btnDodajPopravku_Click(object sender, EventArgs e)
        {
            bool provera = referenca.kreirajPopravku(new ServisAutomehanikeref.Popravka() { id_popravke = (int.Parse(nudIdZaPopravku.Value.ToString())), deo = txtDeo.Text, cena_dela = nudCenaDela.Value });
            lbPopravke.Items.Add("id popravke:" + nudIdZaPopravku.Value.ToString() + " Deo:" + txtDeo.Text + " Cena dela:" + nudCenaDela.Value.ToString());
        }

        private void btnBrisanjePopravke_Click(object sender, EventArgs e)
        {
            bool provera = referenca.izbrisiPopravku(int.Parse(nudIdPopravkeBrisanje.Value.ToString()));
            if (provera)
            {
                if (referenca.deserijalizujPopravkuAzuriranje().Length > 0)
                {
                    lbPopravke.Items.Clear();

                    string[] niz = referenca.deserijalizujPopravkuAzuriranje().Split('|');

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

        private void btnAzurirajPopravku_Click(object sender, EventArgs e)
        {
            bool provera = referenca.azurirajPopravku(int.Parse(nudIdAzuriranjePopravke.Value.ToString()), txtAzuriranjeDeo.Text, nudAzuiranjeCeneDela.Value);
            if (provera)
            {
                if (referenca.deserijalizujAutomobilAzuriranje().Length > 0)
                {
                    lbAutomobili.Items.Clear();

                    string[] niz = referenca.deserijalizujAutomobilAzuriranje().Split('|');

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (!lbAutomobili.Items.Contains(niz[i]))
                        {
                            lbAutomobili.Items.Add(niz[i]);
                        }
                    }
                }
                if (referenca.deserijalizujPopravkuAzuriranje().Length > 0)
                {
                    lbPopravke.Items.Clear();

                    string[] niz = referenca.deserijalizujPopravkuAzuriranje().Split('|');

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
    }
}
