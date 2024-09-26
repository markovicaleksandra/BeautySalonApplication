namespace KorisnickiInterfejs.UserControls
{
    partial class UcUsluge
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
            this.uslugeMenu = new System.Windows.Forms.MenuStrip();
            this.dodajUsluguMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveUslugeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUsluge = new System.Windows.Forms.Panel();
            this.uslugeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uslugeMenu
            // 
            this.uslugeMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uslugeMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uslugeMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uslugeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uslugeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsluguMenuItem,
            this.sveUslugeMenuItem});
            this.uslugeMenu.Location = new System.Drawing.Point(0, 668);
            this.uslugeMenu.Name = "uslugeMenu";
            this.uslugeMenu.Size = new System.Drawing.Size(1081, 31);
            this.uslugeMenu.TabIndex = 1;
            this.uslugeMenu.Text = "menuStrip1";
            // 
            // dodajUsluguMenuItem
            // 
            this.dodajUsluguMenuItem.Name = "dodajUsluguMenuItem";
            this.dodajUsluguMenuItem.Size = new System.Drawing.Size(124, 26);
            this.dodajUsluguMenuItem.Text = "Dodaj Uslugu";
            // 
            // sveUslugeMenuItem
            // 
            this.sveUslugeMenuItem.Name = "sveUslugeMenuItem";
            this.sveUslugeMenuItem.Size = new System.Drawing.Size(105, 26);
            this.sveUslugeMenuItem.Text = "Sve usluge";
            // 
            // pnlUsluge
            // 
            this.pnlUsluge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlUsluge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsluge.Location = new System.Drawing.Point(0, 0);
            this.pnlUsluge.Name = "pnlUsluge";
            this.pnlUsluge.Size = new System.Drawing.Size(1081, 668);
            this.pnlUsluge.TabIndex = 2;
            // 
            // UcUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlUsluge);
            this.Controls.Add(this.uslugeMenu);
            this.Name = "UcUsluge";
            this.Size = new System.Drawing.Size(1081, 699);
            this.uslugeMenu.ResumeLayout(false);
            this.uslugeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnlUsluge;
        public System.Windows.Forms.MenuStrip uslugeMenu;
        public System.Windows.Forms.ToolStripMenuItem dodajUsluguMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sveUslugeMenuItem;
    }
}
