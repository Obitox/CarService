using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operater
{
    public partial class Form1 : Form
    {
        ServisAutomehanikeREF.ServisOperaterClient referenca;

        public Form1()
        {
            InitializeComponent();
            referenca = new ServisAutomehanikeREF.ServisOperaterClient();
        }

        private void btnPrijavljivanje_Click(object sender, EventArgs e)
        {
            bool provera = referenca.prijavljivanje(txtKorisnickoIme.Text, txtLozinka.Text);

            if (provera)
            {
                this.Hide();
                var operatermeni = new OperaterMeni();
                operatermeni.Closed += (s, args) => this.Close();
                operatermeni.Show();
            }
            else
            {
                MessageBox.Show("Molim vas proverite vaše korisničko ime ili šifru!");
            }

        }
    }
}
