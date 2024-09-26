namespace KorisnickiInterfejs.UserControls
{
    partial class UcPretragaKlijenta
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
            dgvKlijenti = new System.Windows.Forms.DataGridView();
            txtIme = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnIzmeniKlijenta = new System.Windows.Forms.Button();
            btnKreirajRezervaciju = new System.Windows.Forms.Button();
            btnDetaljiKlijenta = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKlijenti
            // 
            dgvKlijenti.AllowUserToAddRows = false;
            dgvKlijenti.AllowUserToDeleteRows = false;
            dgvKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
            dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKlijenti.Location = new System.Drawing.Point(35, 118);
            dgvKlijenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvKlijenti.Name = "dgvKlijenti";
            dgvKlijenti.ReadOnly = true;
            dgvKlijenti.RowHeadersWidth = 51;
            dgvKlijenti.RowTemplate.Height = 24;
            dgvKlijenti.Size = new System.Drawing.Size(463, 541);
            dgvKlijenti.TabIndex = 0;
            // 
            // txtIme
            // 
            txtIme.Location = new System.Drawing.Point(128, 83);
            txtIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new System.Drawing.Size(132, 27);
            txtIme.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(35, 42);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(180, 25);
            label5.TabIndex = 33;
            label5.Text = "Pretraga klijenata";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 31;
            label1.Text = "Ime klijenta:";
            // 
            // btnIzmeniKlijenta
            // 
            btnIzmeniKlijenta.BackColor = System.Drawing.Color.AntiqueWhite;
            btnIzmeniKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnIzmeniKlijenta.Location = new System.Drawing.Point(306, 58);
            btnIzmeniKlijenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            btnIzmeniKlijenta.Size = new System.Drawing.Size(192, 39);
            btnIzmeniKlijenta.TabIndex = 34;
            btnIzmeniKlijenta.Text = "Izmeni klijenta";
            btnIzmeniKlijenta.UseVisualStyleBackColor = false;
            // 
            // btnKreirajRezervaciju
            // 
            btnKreirajRezervaciju.BackColor = System.Drawing.Color.AntiqueWhite;
            btnKreirajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKreirajRezervaciju.Location = new System.Drawing.Point(306, 104);
            btnKreirajRezervaciju.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnKreirajRezervaciju.Name = "btnKreirajRezervaciju";
            btnKreirajRezervaciju.Size = new System.Drawing.Size(192, 39);
            btnKreirajRezervaciju.TabIndex = 35;
            btnKreirajRezervaciju.Text = "Kreiraj rezervaciju";
            btnKreirajRezervaciju.UseVisualStyleBackColor = false;
            // 
            // btnDetaljiKlijenta
            // 
            btnDetaljiKlijenta.BackColor = System.Drawing.Color.AntiqueWhite;
            btnDetaljiKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDetaljiKlijenta.Location = new System.Drawing.Point(306, 12);
            btnDetaljiKlijenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDetaljiKlijenta.Name = "btnDetaljiKlijenta";
            btnDetaljiKlijenta.Size = new System.Drawing.Size(192, 39);
            btnDetaljiKlijenta.TabIndex = 36;
            btnDetaljiKlijenta.Text = "Prikaži detalje";
            btnDetaljiKlijenta.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIzmeniKlijenta);
            panel1.Controls.Add(btnKreirajRezervaciju);
            panel1.Controls.Add(btnDetaljiKlijenta);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 679);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(524, 152);
            panel1.TabIndex = 37;
            // 
            // UcPretragaKlijenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLightLight;
            Controls.Add(txtIme);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dgvKlijenti);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UcPretragaKlijenta";
            Size = new System.Drawing.Size(524, 831);
            ((System.ComponentModel.ISupportInitialize)dgvKlijenti).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvKlijenti;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.Button btnIzmeniKlijenta;
        public System.Windows.Forms.Button btnKreirajRezervaciju;
        public System.Windows.Forms.Button btnDetaljiKlijenta;
        private System.Windows.Forms.Panel panel1;
    }
}
