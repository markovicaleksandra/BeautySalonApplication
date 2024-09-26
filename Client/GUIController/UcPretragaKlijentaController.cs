using Common.Domen;
using KorisnickiInterfejs.Helpers;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UcPretragaKlijentaController
    {
        public UcPretragaKlijenta UcPretragaKlijenta { get; set; }
        private BindingList<Klijent> klijenti;
        public async Task<UserControl> CreateUserControlAsync()
        {
            UcPretragaKlijenta = new UcPretragaKlijenta();
            klijenti = new BindingList<Klijent>(await Communication.Instance.UcitajListuKlijenata());
            UcPretragaKlijenta.dgvKlijenti.DataSource = klijenti;
            UcPretragaKlijenta.dgvKlijenti.Columns["IDKlijent"].Visible = false;
            UcPretragaKlijenta.dgvKlijenti.Columns["Telefon"].Visible = false;
            UcPretragaKlijenta.dgvKlijenti.Columns["Email"].Visible = false;

            UcPretragaKlijenta.btnIzmeniKlijenta.Click += btnIzmeniKlijenta_Click;
            UcPretragaKlijenta.txtIme.TextChanged += txtIme_TextChanged;
            UcPretragaKlijenta.btnKreirajRezervaciju.Click += btnKreirajRezervaciju_Click;
            UcPretragaKlijenta.btnDetaljiKlijenta.Click += btnDetaljiKlijenta_Click;
            return UcPretragaKlijenta;
        }

        private void btnDetaljiKlijenta_Click(object sender, EventArgs e)
        {
            if (UcPretragaKlijenta.dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da selektujete klijenta.");
                return;
            }
        
            Klijent klijent = (Klijent)UcPretragaKlijenta.dgvKlijenti.SelectedRows[0].DataBoundItem;
            Coordinator.Instance.ShowUcDodajIzmeniKlijenta(FormMode.Details, klijent);
        }

        private void btnKreirajRezervaciju_Click(object sender, EventArgs e)
        {
            if (UcPretragaKlijenta.dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da selektujete red klijenta za koga želite da kreirate rezervaciju!");
                return;
            }
            Klijent klijent = (Klijent)UcPretragaKlijenta.dgvKlijenti.SelectedRows[0].DataBoundItem;
            Coordinator.Instance.ShowUcRezervacija(klijent);
        }

        private async void txtIme_TextChanged(object sender, EventArgs e)
        {
            string filter = UcPretragaKlijenta.txtIme.Text;
            List<Klijent> rezultatiPretrage = await Communication.Instance.PretraziKlijente(filter);
            if(rezultatiPretrage.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe klijente po zadatoj vrednosti");
            }
            UcPretragaKlijenta.dgvKlijenti.DataSource = new BindingList<Klijent>(rezultatiPretrage);
        }

        private void btnIzmeniKlijenta_Click(object sender, EventArgs e)
        {
            if (UcPretragaKlijenta.dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate da selektujete red klijenta koga želite da izmenite!");
                return;
            }
            Klijent klijent = (Klijent)UcPretragaKlijenta.dgvKlijenti.SelectedRows[0].DataBoundItem;
            Coordinator.Instance.ShowUcDodajIzmeniKlijenta(FormMode.Edit, klijent);
            
        }
    }
}
