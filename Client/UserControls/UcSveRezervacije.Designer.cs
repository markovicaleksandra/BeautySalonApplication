namespace KorisnickiInterfejs.UserControls
{
    partial class UcSveRezervacije
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
            this.dgvSveRezervacije = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiRezervaciju = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSveRezervacije
            // 
            this.dgvSveRezervacije.AllowUserToAddRows = false;
            this.dgvSveRezervacije.AllowUserToDeleteRows = false;
            this.dgvSveRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSveRezervacije.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSveRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSveRezervacije.Location = new System.Drawing.Point(0, 0);
            this.dgvSveRezervacije.Name = "dgvSveRezervacije";
            this.dgvSveRezervacije.ReadOnly = true;
            this.dgvSveRezervacije.RowHeadersWidth = 51;
            this.dgvSveRezervacije.RowTemplate.Height = 24;
            this.dgvSveRezervacije.Size = new System.Drawing.Size(1114, 588);
            this.dgvSveRezervacije.TabIndex = 0;
            // 
            // btnIzbrisiRezervaciju
            // 
            this.btnIzbrisiRezervaciju.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzbrisiRezervaciju.Location = new System.Drawing.Point(914, 25);
            this.btnIzbrisiRezervaciju.Name = "btnIzbrisiRezervaciju";
            this.btnIzbrisiRezervaciju.Size = new System.Drawing.Size(156, 24);
            this.btnIzbrisiRezervaciju.TabIndex = 1;
            this.btnIzbrisiRezervaciju.Text = "Izbriši rezervaciju";
            this.btnIzbrisiRezervaciju.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDatum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbZaposleni);
            this.panel1.Controls.Add(this.btnIzbrisiRezervaciju);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 78);
            this.panel1.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(520, 27);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtriraj po datumu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtriraj po zaposlenom:";
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(173, 25);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(147, 24);
            this.cbZaposleni.TabIndex = 2;
            // 
            // UcSveRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvSveRezervacije);
            this.Controls.Add(this.panel1);
            this.Name = "UcSveRezervacije";
            this.Size = new System.Drawing.Size(1114, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveRezervacije)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSveRezervacije;
        public System.Windows.Forms.Button btnIzbrisiRezervaciju;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpDatum;
        public System.Windows.Forms.ComboBox cbZaposleni;
    }
}
