using KorisnickiInterfejs.Helpers;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UcUslugeController
    {
        public UcUsluge UcUsluge { get; set; }
        public UcUsluge CreateUserControl()
        {
            UcUsluge = new UcUsluge();
            Coordinator.Instance.ShowUcDodajIzmeniUslugu(FormMode.Add);
            UcUsluge.uslugeMenu.Items["dodajUsluguMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcDodajIzmeniUslugu(FormMode.Add);
            UcUsluge.uslugeMenu.Items["sveUslugeMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcSveUsluge();

            return UcUsluge;
        }

        public void ChangePanel(UserControl uc)
        {
            UcUsluge.pnlUsluge.Controls.Clear();
            uc.Parent = UcUsluge.pnlUsluge;
            uc.Dock = DockStyle.Fill;
        }
    }
}
