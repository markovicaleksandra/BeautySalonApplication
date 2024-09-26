using Common.Domen;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UcSveRezervacijeController
    {
        public UcSveRezervacije UcSveRezervacije { get; set; }
        private BindingList<Rezervacija> rezervacije;
        public async Task<UcSveRezervacije> CreateUserControlAsync()
        {
            UcSveRezervacije = new UcSveRezervacije();
            try
            {
                rezervacije = new BindingList<Rezervacija>(await Communication.Instance.UcitajListuRezervacija());
                rezervacije = new BindingList<Rezervacija>((rezervacije.OrderByDescending(rezervacija => rezervacija.Datum.Date)).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UcSveRezervacije.dgvSveRezervacije.DataSource = rezervacije;
            UcSveRezervacije.dgvSveRezervacije.Columns["IDRezervacija"].Visible = false;
            CultureInfo culture = new CultureInfo("sr-Latn-RS");
            UcSveRezervacije.dgvSveRezervacije.Columns["Datum"].DefaultCellStyle.FormatProvider = culture;
            UcSveRezervacije.dgvSveRezervacije.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            UcSveRezervacije.dgvSveRezervacije.Columns["VremePocetka"].HeaderText = "Vreme početka";
            UcSveRezervacije.dgvSveRezervacije.Columns["VremeZavrsetka"].HeaderText = "Vreme završetka";
            UcSveRezervacije.dgvSveRezervacije.Columns["VremePocetka"].DefaultCellStyle.Format = "HH:mm";
            UcSveRezervacije.dgvSveRezervacije.Columns["VremeZavrsetka"].DefaultCellStyle.Format = "HH:mm";

            UcSveRezervacije.cbZaposleni.DataSource = await Communication.Instance.UcitajListuZaposlenih();

            UcSveRezervacije.btnIzbrisiRezervaciju.Click += btnIzbrisiRezervaciju_Click;
            UcSveRezervacije.cbZaposleni.SelectedIndexChanged += cbZaposleni_SelectedIndexChanged;
            UcSveRezervacije.dtpDatum.ValueChanged += dtpDatum_ValueChanged;

            return UcSveRezervacije;
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum = UcSveRezervacije.dtpDatum.Value.Date;
            var filtriraneRezervacije = new BindingList<Rezervacija>(rezervacije.Where(r => r.Datum.Date == datum).ToList());
            UcSveRezervacije.dgvSveRezervacije.DataSource = filtriraneRezervacije;

        }

        private void cbZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zaposleni zaposleni = (Zaposleni)UcSveRezervacije.cbZaposleni.SelectedItem;
            var filtriraneRezervacije = new BindingList<Rezervacija>(rezervacije.Where(r => r.Zaposleni.IDZaposleni == zaposleni.IDZaposleni).ToList());
            UcSveRezervacije.dgvSveRezervacije.DataSource = filtriraneRezervacije;

        }

        private async void btnIzbrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if(UcSveRezervacije.dgvSveRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate selektovati red rezervacije koju želite da izbrišete.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da izbrišete rezervaciju?", "Upozorenje!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Rezervacija izabrana = (Rezervacija)UcSveRezervacije.dgvSveRezervacije.SelectedRows[0].DataBoundItem;
                try
                {
                    await Communication.Instance.IzbrisiRezervaciju(izabrana);
                    MessageBox.Show("Sistem je obrisao rezervaciju.");
                    rezervacije.Remove(izabrana);
                    UcSveRezervacije.dgvSveRezervacije.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da obriše rezervaciju." + ex.Message);
                }
            }
        }
    }
}
