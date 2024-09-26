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
    public class UcSveUslugeController
    {
        public UcSveUsluge UcSveUsluge { get; set; }

        private BindingList<Usluga> usluge;
        public async Task<UcSveUsluge> CreateUserControlAsync()
        {
            UcSveUsluge = new UcSveUsluge();
            usluge = new BindingList<Usluga>(await Communication.Instance.UcitajListuUsluga());
            usluge = new BindingList<Usluga>(usluge.OrderBy(u => u.TipUsluge.NazivTipaUsluge).ToList());

            UcSveUsluge.dgvUsluge.DataSource = usluge;
            UcSveUsluge.dgvUsluge.Columns["IDUsluga"].Visible = false;
            UcSveUsluge.dgvUsluge.Columns["Trajanje"].Visible = false;

            UcSveUsluge.btnIzbrisiUslugu.Click += btnIzbrisiUslugu_Click;
            UcSveUsluge.btnIzmeniUslugu.Click += btnIzmeniUslugu_Click;
            UcSveUsluge.btnDetalji.Click += btnDetalji_Click;

            return UcSveUsluge;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (UcSveUsluge.dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati uslugu.");
                return;
            }
           
            Usluga izabrana = (Usluga)UcSveUsluge.dgvUsluge.SelectedRows[0].DataBoundItem;
            Coordinator.Instance.ShowUcDodajIzmeniUslugu(FormMode.Details,izabrana);
        }

        private void btnIzmeniUslugu_Click(object sender, EventArgs e)
        {
            if (UcSveUsluge.dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati red usluge koju želite da izmenite.");
                return;
            }
            Usluga izabrana = (Usluga)UcSveUsluge.dgvUsluge.SelectedRows[0].DataBoundItem;
            Coordinator.Instance.ShowUcDodajIzmeniUslugu(FormMode.Edit,izabrana);
        }

        private async void btnIzbrisiUslugu_Click(object sender, EventArgs e)
        {
            if(UcSveUsluge.dgvUsluge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati red usluge koju želite da izbrišete.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da izbrišete uslugu?","Upozorenje!" ,MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Usluga izabrana = (Usluga)UcSveUsluge.dgvUsluge.SelectedRows[0].DataBoundItem;
                try
                {
                    await Communication.Instance.IzbrisiUslugu(izabrana);
                    MessageBox.Show("Sistem je obrisao uslugu");
                    usluge.Remove(izabrana);
                    UcSveUsluge.dgvUsluge.Refresh();
                }
                catch (Exception )
                {
                    MessageBox.Show("Sistem ne može da obriše uslugu.");
                }
            }
        }
    }
}
