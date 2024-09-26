namespace KorisnickiInterfejs.UserControls
{
    partial class UcRezervacija
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
            label1 = new System.Windows.Forms.Label();
            cbUsluga = new System.Windows.Forms.ComboBox();
            dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cbTipUsluge = new System.Windows.Forms.ComboBox();
            cbZaposleni = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtNapomena = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            cbKlijenti = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            btnDodajRezervaciju = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtTrajanjeUsluge = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            numericUpDownMinut = new System.Windows.Forms.NumericUpDown();
            numericUpDownSat = new System.Windows.Forms.NumericUpDown();
            dgvRezervacije = new System.Windows.Forms.DataGridView();
            btnSacuvajRezervacije = new System.Windows.Forms.Button();
            btnIzbrisiRezervaciju = new System.Windows.Forms.Button();
            dgvRezervacijeZaDatum = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacijeZaDatum).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(83, 172);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Izaberite uslugu:";
            // 
            // cbUsluga
            // 
            cbUsluga.FormattingEnabled = true;
            cbUsluga.Location = new System.Drawing.Point(245, 169);
            cbUsluga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbUsluga.Name = "cbUsluga";
            cbUsluga.Size = new System.Drawing.Size(200, 28);
            cbUsluga.TabIndex = 1;
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerDatum.Location = new System.Drawing.Point(233, 324);
            dateTimePickerDatum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickerDatum.MinDate = new System.DateTime(2024, 6, 10, 0, 0, 0, 0);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new System.Drawing.Size(200, 27);
            dateTimePickerDatum.TabIndex = 2;
            dateTimePickerDatum.Value = new System.DateTime(2024, 6, 10, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(71, 331);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(83, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Tip usluge:";
            // 
            // cbTipUsluge
            // 
            cbTipUsluge.FormattingEnabled = true;
            cbTipUsluge.Location = new System.Drawing.Point(245, 112);
            cbTipUsluge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbTipUsluge.Name = "cbTipUsluge";
            cbTipUsluge.Size = new System.Drawing.Size(200, 28);
            cbTipUsluge.TabIndex = 5;
            // 
            // cbZaposleni
            // 
            cbZaposleni.FormattingEnabled = true;
            cbZaposleni.Location = new System.Drawing.Point(233, 268);
            cbZaposleni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbZaposleni.Name = "cbZaposleni";
            cbZaposleni.Size = new System.Drawing.Size(200, 28);
            cbZaposleni.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(74, 271);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "Zaposleni:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new System.Drawing.Point(233, 428);
            txtNapomena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new System.Drawing.Size(200, 27);
            txtNapomena.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(74, 428);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 20);
            label5.TabIndex = 9;
            label5.Text = "Napomena:";
            // 
            // cbKlijenti
            // 
            cbKlijenti.FormattingEnabled = true;
            cbKlijenti.Location = new System.Drawing.Point(245, 55);
            cbKlijenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbKlijenti.Name = "cbKlijenti";
            cbKlijenti.Size = new System.Drawing.Size(200, 28);
            cbKlijenti.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(83, 59);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 20);
            label6.TabIndex = 10;
            label6.Text = "Klijent:";
            // 
            // btnDodajRezervaciju
            // 
            btnDodajRezervaciju.BackColor = System.Drawing.Color.AntiqueWhite;
            btnDodajRezervaciju.Location = new System.Drawing.Point(233, 462);
            btnDodajRezervaciju.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            btnDodajRezervaciju.Size = new System.Drawing.Size(200, 41);
            btnDodajRezervaciju.TabIndex = 12;
            btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            btnDodajRezervaciju.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTrajanjeUsluge);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnDodajRezervaciju);
            groupBox1.Controls.Add(cbZaposleni);
            groupBox1.Controls.Add(numericUpDownMinut);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDownSat);
            groupBox1.Controls.Add(txtNapomena);
            groupBox1.Controls.Add(dateTimePickerDatum);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(12, 18);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(482, 524);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiranje rezervacije";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(321, 380);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(50, 20);
            label9.TabIndex = 21;
            label9.Text = "Minut:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(71, 218);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(111, 20);
            label7.TabIndex = 17;
            label7.Text = "Trajanje usluge:";
            // 
            // txtTrajanjeUsluge
            // 
            txtTrajanjeUsluge.BackColor = System.Drawing.Color.White;
            txtTrajanjeUsluge.Location = new System.Drawing.Point(233, 210);
            txtTrajanjeUsluge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTrajanjeUsluge.Name = "txtTrajanjeUsluge";
            txtTrajanjeUsluge.ReadOnly = true;
            txtTrajanjeUsluge.Size = new System.Drawing.Size(200, 27);
            txtTrajanjeUsluge.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(200, 380);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(33, 20);
            label8.TabIndex = 20;
            label8.Text = "Sat:";
            // 
            // numericUpDownMinut
            // 
            numericUpDownMinut.Location = new System.Drawing.Point(365, 378);
            numericUpDownMinut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownMinut.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinut.Name = "numericUpDownMinut";
            numericUpDownMinut.Size = new System.Drawing.Size(68, 27);
            numericUpDownMinut.TabIndex = 19;
            // 
            // numericUpDownSat
            // 
            numericUpDownSat.Location = new System.Drawing.Point(233, 378);
            numericUpDownSat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownSat.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownSat.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownSat.Name = "numericUpDownSat";
            numericUpDownSat.Size = new System.Drawing.Size(68, 27);
            numericUpDownSat.TabIndex = 18;
            numericUpDownSat.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // dgvRezervacije
            // 
            dgvRezervacije.AllowUserToAddRows = false;
            dgvRezervacije.AllowUserToDeleteRows = false;
            dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRezervacije.BackgroundColor = System.Drawing.Color.White;
            dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervacije.GridColor = System.Drawing.SystemColors.Control;
            dgvRezervacije.Location = new System.Drawing.Point(18, 38);
            dgvRezervacije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvRezervacije.Name = "dgvRezervacije";
            dgvRezervacije.ReadOnly = true;
            dgvRezervacije.RowHeadersWidth = 51;
            dgvRezervacije.RowTemplate.Height = 24;
            dgvRezervacije.Size = new System.Drawing.Size(784, 486);
            dgvRezervacije.TabIndex = 14;
            // 
            // btnSacuvajRezervacije
            // 
            btnSacuvajRezervacije.BackColor = System.Drawing.Color.AntiqueWhite;
            btnSacuvajRezervacije.Location = new System.Drawing.Point(654, 616);
            btnSacuvajRezervacije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSacuvajRezervacije.Name = "btnSacuvajRezervacije";
            btnSacuvajRezervacije.Size = new System.Drawing.Size(148, 41);
            btnSacuvajRezervacije.TabIndex = 15;
            btnSacuvajRezervacije.Text = "Sacuvaj rezervacije";
            btnSacuvajRezervacije.UseVisualStyleBackColor = false;
            // 
            // btnIzbrisiRezervaciju
            // 
            btnIzbrisiRezervaciju.BackColor = System.Drawing.Color.AntiqueWhite;
            btnIzbrisiRezervaciju.Location = new System.Drawing.Point(654, 568);
            btnIzbrisiRezervaciju.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIzbrisiRezervaciju.Name = "btnIzbrisiRezervaciju";
            btnIzbrisiRezervaciju.Size = new System.Drawing.Size(148, 41);
            btnIzbrisiRezervaciju.TabIndex = 16;
            btnIzbrisiRezervaciju.Text = "Izbrisi rezervaciju";
            btnIzbrisiRezervaciju.UseVisualStyleBackColor = false;
            // 
            // dgvRezervacijeZaDatum
            // 
            dgvRezervacijeZaDatum.AllowUserToAddRows = false;
            dgvRezervacijeZaDatum.AllowUserToDeleteRows = false;
            dgvRezervacijeZaDatum.BackgroundColor = System.Drawing.Color.White;
            dgvRezervacijeZaDatum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervacijeZaDatum.GridColor = System.Drawing.SystemColors.Control;
            dgvRezervacijeZaDatum.Location = new System.Drawing.Point(15, 26);
            dgvRezervacijeZaDatum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvRezervacijeZaDatum.Name = "dgvRezervacijeZaDatum";
            dgvRezervacijeZaDatum.ReadOnly = true;
            dgvRezervacijeZaDatum.RowHeadersWidth = 51;
            dgvRezervacijeZaDatum.RowTemplate.Height = 24;
            dgvRezervacijeZaDatum.Size = new System.Drawing.Size(418, 245);
            dgvRezervacijeZaDatum.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRezervacijeZaDatum);
            groupBox2.Location = new System.Drawing.Point(12, 549);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(482, 286);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Zauzeti termini za izabranog zaposlenog:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnIzbrisiRezervaciju);
            groupBox3.Controls.Add(dgvRezervacije);
            groupBox3.Controls.Add(btnSacuvajRezervacije);
            groupBox3.Location = new System.Drawing.Point(515, 18);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(820, 818);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Unete rezervacije";
            // 
            // UcRezervacija
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            Controls.Add(cbKlijenti);
            Controls.Add(label6);
            Controls.Add(cbTipUsluge);
            Controls.Add(label3);
            Controls.Add(cbUsluga);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UcRezervacija";
            Size = new System.Drawing.Size(1352, 850);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinut).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacijeZaDatum).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbUsluga;
        public System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        public System.Windows.Forms.ComboBox cbTipUsluge;
        public System.Windows.Forms.ComboBox cbZaposleni;
        public System.Windows.Forms.TextBox txtNapomena;
        public System.Windows.Forms.ComboBox cbKlijenti;
        public System.Windows.Forms.Button btnDodajRezervaciju;
        public System.Windows.Forms.DataGridView dgvRezervacije;
        public System.Windows.Forms.Button btnSacuvajRezervacije;
        public System.Windows.Forms.Button btnIzbrisiRezervaciju;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTrajanjeUsluge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown numericUpDownMinut;
        public System.Windows.Forms.NumericUpDown numericUpDownSat;
        public System.Windows.Forms.DataGridView dgvRezervacijeZaDatum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
