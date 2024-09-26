using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuMain = new System.Windows.Forms.MenuStrip();
            klijentiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            uslugeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rezervacijeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zaposleniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlMain = new System.Windows.Forms.Panel();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.BackColor = System.Drawing.Color.AntiqueWhite;
            menuMain.Dock = System.Windows.Forms.DockStyle.Left;
            menuMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { klijentiMenuItem, uslugeMenuItem, rezervacijeMenuItem, zaposleniMenuItem });
            menuMain.Location = new System.Drawing.Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new System.Drawing.Size(117, 860);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // klijentiMenuItem
            // 
            klijentiMenuItem.Name = "klijentiMenuItem";
            klijentiMenuItem.Size = new System.Drawing.Size(104, 24);
            klijentiMenuItem.Text = "Klijenti";
            // 
            // uslugeMenuItem
            // 
            uslugeMenuItem.Name = "uslugeMenuItem";
            uslugeMenuItem.Size = new System.Drawing.Size(104, 24);
            uslugeMenuItem.Text = "Usluge";
            // 
            // rezervacijeMenuItem
            // 
            rezervacijeMenuItem.Name = "rezervacijeMenuItem";
            rezervacijeMenuItem.Size = new System.Drawing.Size(104, 24);
            rezervacijeMenuItem.Text = "Rezervacije";
            // 
            // zaposleniMenuItem
            // 
            zaposleniMenuItem.Name = "zaposleniMenuItem";
            zaposleniMenuItem.Size = new System.Drawing.Size(104, 24);
            zaposleniMenuItem.Text = "Zaposleni";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(117, 0);
            pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1371, 860);
            pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1488, 860);
            Controls.Add(pnlMain);
            Controls.Add(menuMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuMain;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kozmetički salon ";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.MenuStrip menuMain;
        public System.Windows.Forms.ToolStripMenuItem klijentiMenuItem;
        public System.Windows.Forms.ToolStripMenuItem uslugeMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rezervacijeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniMenuItem;
        public System.Windows.Forms.Panel pnlMain;
    }
}

