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
    public partial class Prijavljivanje : Form
    {
        ServisAutomehanikeref.ServisAdminClient referenca;

        public Prijavljivanje()
        {
            InitializeComponent();
            referenca = new ServisAutomehanikeref.ServisAdminClient();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            bool provera = referenca.prijavljivanjeAdmina(txtKorisnickoIme.Text, txtLozinka.Text);

            if (provera)
            {
                this.Hide();
                var adminmeni = new AdminMeni();
                adminmeni.Closed += (s, args) => this.Close();
                adminmeni.Show();
            }
            else
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka");
            }
        }
    }
}
