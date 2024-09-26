namespace KorisnickiInterfejs.UserControls
{
    partial class UcZaposleni
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbIzmena = new System.Windows.Forms.GroupBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoviUsluga = new System.Windows.Forms.ComboBox();
            this.btnDodajtip = new System.Windows.Forms.Button();
            this.btnIzbrisiTip = new System.Windows.Forms.Button();
            this.dgvTipoviUsluga = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.dgvZaposleni = new System.Windows.Forms.DataGridView();
            this.gbIzmena.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviUsluga)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIzmena
            // 
            this.gbIzmena.Controls.Add(this.btnSacuvajIzmene);
            this.gbIzmena.Controls.Add(this.groupBox3);
            this.gbIzmena.Controls.Add(this.label4);
            this.gbIzmena.Controls.Add(this.label3);
            this.gbIzmena.Controls.Add(this.label2);
            this.gbIzmena.Controls.Add(this.label1);
            this.gbIzmena.Controls.Add(this.txtPrezime);
            this.gbIzmena.Controls.Add(this.txtTelefon);
            this.gbIzmena.Controls.Add(this.txtAdresa);
            this.gbIzmena.Controls.Add(this.txtIme);
            this.gbIzmena.Location = new System.Drawing.Point(520, 16);
            this.gbIzmena.Name = "gbIzmena";
            this.gbIzmena.Size = new System.Drawing.Size(462, 569);
            this.gbIzmena.TabIndex = 0;
            this.gbIzmena.TabStop = false;
            this.gbIzmena.Text = "Izmena zaposlenog";
            this.gbIzmena.Visible = false;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(273, 507);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(149, 38);
            this.btnSacuvajIzmene.TabIndex = 12;
            this.btnSacuvajIzmene.Text = "Sačuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbTipoviUsluga);
            this.groupBox3.Controls.Add(this.btnDodajtip);
            this.groupBox3.Controls.Add(this.btnIzbrisiTip);
            this.groupBox3.Controls.Add(this.dgvTipoviUsluga);
            this.groupBox3.Location = new System.Drawing.Point(41, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 262);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipovi usluga ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izaberite tip usluge:";
            // 
            // cbTipoviUsluga
            // 
            this.cbTipoviUsluga.FormattingEnabled = true;
            this.cbTipoviUsluga.Location = new System.Drawing.Point(22, 65);
            this.cbTipoviUsluga.Name = "cbTipoviUsluga";
            this.cbTipoviUsluga.Size = new System.Drawing.Size(222, 24);
            this.cbTipoviUsluga.TabIndex = 3;
            // 
            // btnDodajtip
            // 
            this.btnDodajtip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDodajtip.Location = new System.Drawing.Point(261, 65);
            this.btnDodajtip.Name = "btnDodajtip";
            this.btnDodajtip.Size = new System.Drawing.Size(102, 24);
            this.btnDodajtip.TabIndex = 2;
            this.btnDodajtip.Text = "Dodaj tip";
            this.btnDodajtip.UseVisualStyleBackColor = false;
            // 
            // btnIzbrisiTip
            // 
            this.btnIzbrisiTip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzbrisiTip.Location = new System.Drawing.Point(261, 206);
            this.btnIzbrisiTip.Name = "btnIzbrisiTip";
            this.btnIzbrisiTip.Size = new System.Drawing.Size(102, 31);
            this.btnIzbrisiTip.TabIndex = 1;
            this.btnIzbrisiTip.Text = "Izbrisi tip";
            this.btnIzbrisiTip.UseVisualStyleBackColor = false;
            // 
            // dgvTipoviUsluga
            // 
            this.dgvTipoviUsluga.AllowUserToAddRows = false;
            this.dgvTipoviUsluga.AllowUserToDeleteRows = false;
            this.dgvTipoviUsluga.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTipoviUsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoviUsluga.Location = new System.Drawing.Point(22, 116);
            this.dgvTipoviUsluga.Name = "dgvTipoviUsluga";
            this.dgvTipoviUsluga.ReadOnly = true;
            this.dgvTipoviUsluga.RowHeadersWidth = 51;
            this.dgvTipoviUsluga.RowTemplate.Height = 24;
            this.dgvTipoviUsluga.Size = new System.Drawing.Size(222, 121);
            this.dgvTipoviUsluga.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(142, 100);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(262, 22);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(142, 144);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(262, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(142, 187);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(262, 22);
            this.txtAdresa.TabIndex = 2;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(142, 57);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(262, 22);
            this.txtIme.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzmeniZaposlenog);
            this.groupBox2.Controls.Add(this.dgvZaposleni);
            this.groupBox2.Location = new System.Drawing.Point(20, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 569);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Svi zaposleni";
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(271, 507);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(149, 38);
            this.btnIzmeniZaposlenog.TabIndex = 11;
            this.btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = false;
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToAddRows = false;
            this.dgvZaposleni.AllowUserToDeleteRows = false;
            this.dgvZaposleni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZaposleni.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposleni.Location = new System.Drawing.Point(28, 60);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.ReadOnly = true;
            this.dgvZaposleni.RowHeadersWidth = 51;
            this.dgvZaposleni.RowTemplate.Height = 24;
            this.dgvZaposleni.Size = new System.Drawing.Size(392, 416);
            this.dgvZaposleni.TabIndex = 0;
            // 
            // UcZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbIzmena);
            this.Name = "UcZaposleni";
            this.Size = new System.Drawing.Size(985, 609);
            this.gbIzmena.ResumeLayout(false);
            this.gbIzmena.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviUsluga)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvZaposleni;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.TextBox txtPrezime;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbTipoviUsluga;
        public System.Windows.Forms.Button btnDodajtip;
        public System.Windows.Forms.DataGridView dgvTipoviUsluga;
        public System.Windows.Forms.Button btnIzmeniZaposlenog;
        public System.Windows.Forms.GroupBox gbIzmena;
        public System.Windows.Forms.Button btnIzbrisiTip;
        public System.Windows.Forms.Button btnSacuvajIzmene;
    }
}
