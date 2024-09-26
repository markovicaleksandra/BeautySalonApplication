using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class FrmMainController
    {
        public FrmMain FrmMain { get; set; }
        public FrmMain CreateMainForm()
        {
            FrmMain = new FrmMain();
            FrmMain.menuMain.Items["klijentiMenuItem"].Click += (s,a) => Coordinator.Instance.ShowUcKlijenti();
            FrmMain.menuMain.Items["uslugeMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcUsluge();
            FrmMain.menuMain.Items["rezervacijeMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcSveRezervacije();
            FrmMain.menuMain.Items["zaposleniMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcZaposleni();

            return FrmMain;
        }

        public void ChangePanel(UserControl uc)
        {
            FrmMain.pnlMain.Controls.Clear();
            uc.Parent = FrmMain.pnlMain;
            uc.Dock = DockStyle.Fill;
        }
    }
}
