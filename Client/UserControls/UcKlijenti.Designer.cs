namespace KorisnickiInterfejs.UserControls
{
    partial class UcKlijenti
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
            this.klijentiMenu = new System.Windows.Forms.MenuStrip();
            this.dodajKlijentaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKlijenti = new System.Windows.Forms.Panel();
            this.klijentiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // klijentiMenu
            // 
            this.klijentiMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.klijentiMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.klijentiMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klijentiMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.klijentiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.klijentiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKlijentaMenuItem,
            this.pretragaMenuItem});
            this.klijentiMenu.Location = new System.Drawing.Point(0, 578);
            this.klijentiMenu.Name = "klijentiMenu";
            this.klijentiMenu.Size = new System.Drawing.Size(1223, 31);
            this.klijentiMenu.TabIndex = 21;
            this.klijentiMenu.Text = "menuStrip1";
            // 
            // dodajKlijentaMenuItem
            // 
            this.dodajKlijentaMenuItem.Name = "dodajKlijentaMenuItem";
            this.dodajKlijentaMenuItem.Size = new System.Drawing.Size(130, 27);
            this.dodajKlijentaMenuItem.Text = "Dodaj Klijenta";
            // 
            // pretragaMenuItem
            // 
            this.pretragaMenuItem.Name = "pretragaMenuItem";
            this.pretragaMenuItem.Size = new System.Drawing.Size(89, 27);
            this.pretragaMenuItem.Text = "Pretraga";
            // 
            // pnlKlijenti
            // 
            this.pnlKlijenti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKlijenti.Location = new System.Drawing.Point(0, 0);
            this.pnlKlijenti.Name = "pnlKlijenti";
            this.pnlKlijenti.Size = new System.Drawing.Size(1223, 578);
            this.pnlKlijenti.TabIndex = 22;
            // 
            // UcKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlKlijenti);
            this.Controls.Add(this.klijentiMenu);
            this.Name = "UcKlijenti";
            this.Size = new System.Drawing.Size(1223, 609);
            this.klijentiMenu.ResumeLayout(false);
            this.klijentiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dodajKlijentaMenuItem;
        public System.Windows.Forms.MenuStrip klijentiMenu;
        public System.Windows.Forms.Panel pnlKlijenti;
        public System.Windows.Forms.ToolStripMenuItem pretragaMenuItem;
    }
}
