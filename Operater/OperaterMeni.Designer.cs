namespace Operater
{
    partial class OperaterMeni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNapraviAutomobil = new System.Windows.Forms.Button();
            this.nudCenaPopravke = new System.Windows.Forms.NumericUpDown();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.txtPodaci = new System.Windows.Forms.TextBox();
            this.lbAutomobili = new System.Windows.Forms.ListBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtDodajKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtDodajLozinku = new System.Windows.Forms.TextBox();
            this.btnPotvrdiKorisnika = new System.Windows.Forms.Button();
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.nudIdPopravke = new System.Windows.Forms.NumericUpDown();
            this.nudCenaDela = new System.Windows.Forms.NumericUpDown();
            this.txtDeo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPopravke = new System.Windows.Forms.ListBox();
            this.nudAzurirajPopravku = new System.Windows.Forms.NumericUpDown();
            this.nudNovaCenaDela = new System.Windows.Forms.NumericUpDown();
            this.txtAzurirajCenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaPopravke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPopravke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaDela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzurirajPopravku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNovaCenaDela)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNapraviAutomobil
            // 
            this.btnNapraviAutomobil.Location = new System.Drawing.Point(72, 117);
            this.btnNapraviAutomobil.Name = "btnNapraviAutomobil";
            this.btnNapraviAutomobil.Size = new System.Drawing.Size(134, 23);
            this.btnNapraviAutomobil.TabIndex = 15;
            this.btnNapraviAutomobil.Text = "Dodaj Automobil";
            this.btnNapraviAutomobil.UseVisualStyleBackColor = true;
            this.btnNapraviAutomobil.Click += new System.EventHandler(this.btnNapraviAutomobil_Click);
            // 
            // nudCenaPopravke
            // 
            this.nudCenaPopravke.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCenaPopravke.Location = new System.Drawing.Point(72, 91);
            this.nudCenaPopravke.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudCenaPopravke.Name = "nudCenaPopravke";
            this.nudCenaPopravke.Size = new System.Drawing.Size(120, 20);
            this.nudCenaPopravke.TabIndex = 14;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(71, 65);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnik.TabIndex = 13;
            // 
            // txtPodaci
            // 
            this.txtPodaci.Location = new System.Drawing.Point(71, 12);
            this.txtPodaci.Name = "txtPodaci";
            this.txtPodaci.Size = new System.Drawing.Size(100, 20);
            this.txtPodaci.TabIndex = 11;
            // 
            // lbAutomobili
            // 
            this.lbAutomobili.FormattingEnabled = true;
            this.lbAutomobili.HorizontalScrollbar = true;
            this.lbAutomobili.Location = new System.Drawing.Point(212, 26);
            this.lbAutomobili.Name = "lbAutomobili";
            this.lbAutomobili.Size = new System.Drawing.Size(458, 95);
            this.lbAutomobili.TabIndex = 16;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "popravlja se",
            "popravljen",
            "nije stigao na red"});
            this.cbStatus.Location = new System.Drawing.Point(71, 38);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 17;
            // 
            // txtDodajKorisnickoIme
            // 
            this.txtDodajKorisnickoIme.Location = new System.Drawing.Point(76, 164);
            this.txtDodajKorisnickoIme.Name = "txtDodajKorisnickoIme";
            this.txtDodajKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtDodajKorisnickoIme.TabIndex = 18;
            // 
            // txtDodajLozinku
            // 
            this.txtDodajLozinku.Location = new System.Drawing.Point(76, 190);
            this.txtDodajLozinku.Name = "txtDodajLozinku";
            this.txtDodajLozinku.Size = new System.Drawing.Size(100, 20);
            this.txtDodajLozinku.TabIndex = 19;
            // 
            // btnPotvrdiKorisnika
            // 
            this.btnPotvrdiKorisnika.Location = new System.Drawing.Point(86, 216);
            this.btnPotvrdiKorisnika.Name = "btnPotvrdiKorisnika";
            this.btnPotvrdiKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdiKorisnika.TabIndex = 20;
            this.btnPotvrdiKorisnika.Text = "Potvrdi";
            this.btnPotvrdiKorisnika.UseVisualStyleBackColor = true;
            this.btnPotvrdiKorisnika.Click += new System.EventHandler(this.btnPotvrdiKorisnika_Click);
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.HorizontalScrollbar = true;
            this.lbKorisnici.Location = new System.Drawing.Point(212, 157);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(458, 82);
            this.lbKorisnici.TabIndex = 21;
            // 
            // nudIdPopravke
            // 
            this.nudIdPopravke.Location = new System.Drawing.Point(76, 258);
            this.nudIdPopravke.Name = "nudIdPopravke";
            this.nudIdPopravke.Size = new System.Drawing.Size(120, 20);
            this.nudIdPopravke.TabIndex = 24;
            // 
            // nudCenaDela
            // 
            this.nudCenaDela.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCenaDela.Location = new System.Drawing.Point(76, 310);
            this.nudCenaDela.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCenaDela.Name = "nudCenaDela";
            this.nudCenaDela.Size = new System.Drawing.Size(120, 20);
            this.nudCenaDela.TabIndex = 25;
            // 
            // txtDeo
            // 
            this.txtDeo.Location = new System.Drawing.Point(76, 284);
            this.txtDeo.Name = "txtDeo";
            this.txtDeo.Size = new System.Drawing.Size(100, 20);
            this.txtDeo.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Dodaj Popravku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPopravke
            // 
            this.lbPopravke.FormattingEnabled = true;
            this.lbPopravke.HorizontalScrollbar = true;
            this.lbPopravke.Location = new System.Drawing.Point(215, 275);
            this.lbPopravke.Name = "lbPopravke";
            this.lbPopravke.Size = new System.Drawing.Size(466, 108);
            this.lbPopravke.TabIndex = 28;
            // 
            // nudAzurirajPopravku
            // 
            this.nudAzurirajPopravku.Location = new System.Drawing.Point(86, 377);
            this.nudAzurirajPopravku.Name = "nudAzurirajPopravku";
            this.nudAzurirajPopravku.Size = new System.Drawing.Size(120, 20);
            this.nudAzurirajPopravku.TabIndex = 31;
            // 
            // nudNovaCenaDela
            // 
            this.nudNovaCenaDela.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNovaCenaDela.Location = new System.Drawing.Point(86, 403);
            this.nudNovaCenaDela.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNovaCenaDela.Name = "nudNovaCenaDela";
            this.nudNovaCenaDela.Size = new System.Drawing.Size(120, 20);
            this.nudNovaCenaDela.TabIndex = 32;
            // 
            // txtAzurirajCenu
            // 
            this.txtAzurirajCenu.Location = new System.Drawing.Point(36, 429);
            this.txtAzurirajCenu.Name = "txtAzurirajCenu";
            this.txtAzurirajCenu.Size = new System.Drawing.Size(157, 23);
            this.txtAzurirajCenu.TabIndex = 33;
            this.txtAzurirajCenu.Text = "Azuriraj Cenu";
            this.txtAzurirajCenu.UseVisualStyleBackColor = true;
            this.txtAzurirajCenu.Click += new System.EventHandler(this.txtAzurirajCenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Podaci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Korisn. Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Id popravke:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Korisn. Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Lozinka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Id popravke:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Deo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Cena dela:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Id popravke:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Nova cena:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Automobili:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Korisnici:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Popravke:";
            // 
            // OperaterMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 675);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAzurirajCenu);
            this.Controls.Add(this.nudNovaCenaDela);
            this.Controls.Add(this.nudAzurirajPopravku);
            this.Controls.Add(this.lbPopravke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeo);
            this.Controls.Add(this.nudCenaDela);
            this.Controls.Add(this.nudIdPopravke);
            this.Controls.Add(this.lbKorisnici);
            this.Controls.Add(this.btnPotvrdiKorisnika);
            this.Controls.Add(this.txtDodajLozinku);
            this.Controls.Add(this.txtDodajKorisnickoIme);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbAutomobili);
            this.Controls.Add(this.btnNapraviAutomobil);
            this.Controls.Add(this.nudCenaPopravke);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.txtPodaci);
            this.Name = "OperaterMeni";
            this.Text = "OperaterMeni";
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaPopravke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPopravke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCenaDela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzurirajPopravku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNovaCenaDela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNapraviAutomobil;
        private System.Windows.Forms.NumericUpDown nudCenaPopravke;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.TextBox txtPodaci;
        private System.Windows.Forms.ListBox lbAutomobili;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtDodajKorisnickoIme;
        private System.Windows.Forms.TextBox txtDodajLozinku;
        private System.Windows.Forms.Button btnPotvrdiKorisnika;
        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.NumericUpDown nudIdPopravke;
        private System.Windows.Forms.NumericUpDown nudCenaDela;
        private System.Windows.Forms.TextBox txtDeo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbPopravke;
        private System.Windows.Forms.NumericUpDown nudAzurirajPopravku;
        private System.Windows.Forms.NumericUpDown nudNovaCenaDela;
        private System.Windows.Forms.Button txtAzurirajCenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}