namespace KorisnickiInterfejs.UserControls
{
    partial class UcSveUsluge
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
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.btnIzbrisiUslugu = new System.Windows.Forms.Button();
            this.btnIzmeniUslugu = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsluge.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsluge.Location = new System.Drawing.Point(0, 0);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(572, 448);
            this.dgvUsluge.TabIndex = 0;
            // 
            // btnIzbrisiUslugu
            // 
            this.btnIzbrisiUslugu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzbrisiUslugu.Location = new System.Drawing.Point(222, 36);
            this.btnIzbrisiUslugu.Name = "btnIzbrisiUslugu";
            this.btnIzbrisiUslugu.Size = new System.Drawing.Size(124, 32);
            this.btnIzbrisiUslugu.TabIndex = 1;
            this.btnIzbrisiUslugu.Text = "Izbriši uslugu";
            this.btnIzbrisiUslugu.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniUslugu
            // 
            this.btnIzmeniUslugu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIzmeniUslugu.Location = new System.Drawing.Point(405, 36);
            this.btnIzmeniUslugu.Name = "btnIzmeniUslugu";
            this.btnIzmeniUslugu.Size = new System.Drawing.Size(123, 32);
            this.btnIzmeniUslugu.TabIndex = 2;
            this.btnIzmeniUslugu.Text = "Izmeni uslugu";
            this.btnIzmeniUslugu.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDetalji.Location = new System.Drawing.Point(34, 36);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(124, 32);
            this.btnDetalji.TabIndex = 3;
            this.btnDetalji.Text = "Prikaži detalje";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIzmeniUslugu);
            this.panel1.Controls.Add(this.btnDetalji);
            this.panel1.Controls.Add(this.btnIzbrisiUslugu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 107);
            this.panel1.TabIndex = 4;
            // 
            // UcSveUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsluge);
            this.Name = "UcSveUsluge";
            this.Size = new System.Drawing.Size(572, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvUsluge;
        public System.Windows.Forms.Button btnIzbrisiUslugu;
        public System.Windows.Forms.Button btnIzmeniUslugu;
        public System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Panel panel1;
    }
}
