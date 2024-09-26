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
    public class UcKlijentiController
    {
        public UcKlijenti UcKlijenti { get; set; }
        public UcKlijenti CreateUserControl()
        {
            UcKlijenti = new UcKlijenti();
            Coordinator.Instance.ShowUcDodajIzmeniKlijenta(FormMode.Add);
            UcKlijenti.klijentiMenu.Items["dodajKlijentaMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcDodajIzmeniKlijenta(FormMode.Add);
            UcKlijenti.klijentiMenu.Items["pretragaMenuItem"].Click += (s, a) => Coordinator.Instance.ShowUcPretragaKlijenta();
          
            return UcKlijenti;
        }

        public void ChangePanel(UserControl uc)
        {
            UcKlijenti.pnlKlijenti.Controls.Clear();
            uc.Parent = UcKlijenti.pnlKlijenti;
            uc.Dock = DockStyle.Fill;
        }
    }
}
