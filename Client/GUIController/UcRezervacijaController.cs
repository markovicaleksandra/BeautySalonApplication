using Common.Domen;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UcRezervacijaController
    {
        public UcRezervacija UcRezervacija { get; set; }

        private BindingList<Rezervacija> rezervacije;
        private List<Rezervacija> rezervacijeZaDatum;

        public async Task<UcRezervacija> CreateUserControl(Klijent klijent)
        {
            UcRezervacija = new UcRezervacija();
            rezervacije = new BindingList<Rezervacija>();
            //rezervacijeZaDatum = await Communication.Instance.UcitajListuRezervacija();

            PostaviPocetnoStanjePolja();

            UcRezervacija.cbTipUsluge.DataSource = await Communication.Instance.UcitajListuTipovaUsluga();
            UcRezervacija.cbTipUsluge.SelectedIndex = -1;
            UcRezervacija.cbTipUsluge.SelectedIndexChanged += cbTipUsluge_SelectedIndexChanged;


            UcRezervacija.cbKlijenti.DataSource = await Communication.Instance.UcitajListuKlijenata();
            UcRezervacija.cbKlijenti.SelectedItem = klijent;
            UcRezervacija.cbKlijenti.Enabled = false;

            UcRezervacija.cbZaposleni.SelectedIndexChanged += cbZaposleni_SelectedIndexChanged;
            UcRezervacija.cbZaposleni.SelectedIndexChanged += dateTimePickerDatum_ValueChanged;

            UcRezervacija.dateTimePickerDatum.Format = DateTimePickerFormat.Custom;
            UcRezervacija.dateTimePickerDatum.CustomFormat = "dd.MM.yyyy";
            UcRezervacija.dateTimePickerDatum.MinDate = DateTime.Now.Date;
            UcRezervacija.dateTimePickerDatum.ValueChanged += dateTimePickerDatum_ValueChanged;

            UcRezervacija.dgvRezervacije.DataSource = rezervacije;
            FormatirajDgvRezervacije(UcRezervacija.dgvRezervacije);
            
            UcRezervacija.cbUsluga.SelectedValueChanged += cbUsluga_SelectedValueChanged; 

            UcRezervacija.btnDodajRezervaciju.Click += btnDodajRezervaciju_Click;
            UcRezervacija.btnIzbrisiRezervaciju.Click += btnIzbrisiRezervaciju_Click;
            UcRezervacija.btnSacuvajRezervacije.Click += btnSacuvajRezervacije_Click;
            return UcRezervacija;
        }

        private void PostaviPocetnoStanjePolja()
        {
            UcRezervacija.cbZaposleni.Enabled = false;
            UcRezervacija.cbZaposleni.SelectedIndex = -1;

            UcRezervacija.cbUsluga.Enabled = false;
            UcRezervacija.cbUsluga.SelectedIndex = -1;
            UcRezervacija.txtTrajanjeUsluge.Text = string.Empty;

            UcRezervacija.dateTimePickerDatum.Enabled = false;
        }

        private void FormatirajDgvRezervacije(DataGridView dgv)
        {
            CultureInfo culture = new CultureInfo("sr-Latn-RS");
            dgv.Columns["IDRezervacija"].Visible = false;
            dgv.Columns["Datum"].DefaultCellStyle.FormatProvider = culture;
            dgv.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgv.Columns["VremePocetka"].HeaderText = "Vreme početka";
            dgv.Columns["VremeZavrsetka"].HeaderText = "Vreme završetka";
            dgv.Columns["VremePocetka"].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns["VremeZavrsetka"].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns["Klijent"].Visible = false;

        }

        private async void btnSacuvajRezervacije_Click(object sender, EventArgs e)
        {
            if(rezervacije.Count == 0)
            {
                MessageBox.Show("Nije kreirana nijedna rezervacija!");
                return;
            }
            try
            {
                await Communication.Instance.SacuvajRezervacije(rezervacije.ToList());
                MessageBox.Show("Sistem je zapamtio rezervacije.");
                rezervacije.Clear();
                PostaviPocetnoStanjePolja();
            }
            catch (Exception )
            {
                MessageBox.Show("Sistem ne može da zapamti rezervacije.");
            }
        }

        private void cbZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcRezervacija.dateTimePickerDatum.Enabled = true;
        }

        private async void dateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {
            if (UcRezervacija.cbZaposleni.SelectedIndex == -1) return;
            if (UcRezervacija.cbZaposleni.SelectedItem == null) return;
            if (UcRezervacija.dateTimePickerDatum.Value < DateTime.Now.Date) return;
            rezervacijeZaDatum = await Communication.Instance.UcitajListuRezervacija();
            Zaposleni zaposleni = (Zaposleni)UcRezervacija.cbZaposleni.SelectedItem;
            DateTime datum = UcRezervacija.dateTimePickerDatum.Value.Date;
            rezervacijeZaDatum = rezervacijeZaDatum.Where(r => r.Datum.Date == datum && r.Zaposleni.IDZaposleni == zaposleni.IDZaposleni).ToList();
            UcRezervacija.dgvRezervacijeZaDatum.DataSource = rezervacijeZaDatum;
            FormatirajDgvRezervacije(UcRezervacija.dgvRezervacijeZaDatum);
            UcRezervacija.dgvRezervacijeZaDatum.Columns["Usluga"].Visible = false;
            UcRezervacija.dgvRezervacijeZaDatum.Columns["Napomena"].Visible = false;

        }

        private void cbUsluga_SelectedValueChanged(object sender, EventArgs e)
        {
            if (UcRezervacija.cbUsluga.SelectedItem == null) return;
            UcRezervacija.txtTrajanjeUsluge.Text = ((Usluga)UcRezervacija.cbUsluga.SelectedItem).Trajanje.ToString();
        }

        private void btnIzbrisiRezervaciju_Click(object sender, EventArgs e)
        {
            if(UcRezervacija.dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati red rezervacije koju želite da uklonite.");
                return;
            }
            Rezervacija rezervacija = (Rezervacija)UcRezervacija.dgvRezervacije.SelectedRows[0].DataBoundItem;
            rezervacije.Remove(rezervacija);
            UcRezervacija.dgvRezervacije.Refresh();
        }

        private async void cbTipUsluge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vracanje usluga po tipu usluge
            UcRezervacija.cbUsluga.Enabled = true;
            UcRezervacija.cbUsluga.SelectedIndex = -1;
            TipUsluge tipUsluge = (TipUsluge)UcRezervacija.cbTipUsluge.SelectedItem;
            UcRezervacija.cbUsluga.DataSource = await Communication.Instance.UcitajListuUslugaPoTipu(tipUsluge);
            //vracanje zaposlenih po tipu usluge
            UcRezervacija.cbZaposleni.Enabled = true;
            UcRezervacija.cbZaposleni.DataSource = await Communication.Instance.UcitajListuZaposlenihPoTipuUsluge(tipUsluge);
            //UcRezervacija.cbZaposleni.SelectedIndex = -1;

        }

        private async void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            int sati = (int)UcRezervacija.numericUpDownSat.Value;
            int min = (int)UcRezervacija.numericUpDownMinut.Value;
            DateTime datum = UcRezervacija.dateTimePickerDatum.Value.Date;
            Rezervacija rezervacija = new Rezervacija()
            {
                Klijent = (Klijent)UcRezervacija.cbKlijenti.SelectedItem,
                Usluga = (Usluga)UcRezervacija.cbUsluga.SelectedItem,
                Napomena = UcRezervacija.txtNapomena.Text,
                Datum = datum,
                VremePocetka = datum.AddHours(sati).AddMinutes(min),
                Zaposleni = (Zaposleni)UcRezervacija.cbZaposleni.SelectedItem
            };
            rezervacija.VremeZavrsetka = rezervacija.VremePocetka.AddMinutes(rezervacija.Usluga.Trajanje);
            //OVDE PROVERI DOSTUPNOST TERMINA
            //ako se vrati true, termin je ZAUZET
            try
            {
                if (await Communication.Instance.ProveriDostupnostTermina(rezervacija))
                {
                    MessageBox.Show("Izabrani termin je zauzet!");
                    return;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            //Provera preklapanja termina u postojecoj listi rezervacija
            foreach (Rezervacija rez in rezervacije)
            {
                if (rez.Datum.Date == rezervacija.Datum.Date)
                {
                    if (rezervacija.VremePocetka >= rez.VremePocetka && rezervacija.VremePocetka <= rez.VremeZavrsetka ||
                        rezervacija.VremeZavrsetka >= rez.VremePocetka && rezervacija.VremeZavrsetka <= rez.VremeZavrsetka ||
                        rezervacija.VremePocetka <= rez.VremePocetka && rezervacija.VremeZavrsetka >= rez.VremeZavrsetka)
                    {
                        MessageBox.Show("Dolazi do preklapanja termina sa već postojećom rezervacijom!");
                        return;
                    }
                }
            }
            rezervacije.Add(rezervacija);
            PostaviPocetnoStanjePolja();
        }
        
        private bool IsValid()
        {
            bool uspesno = true;
            if(UcRezervacija.cbTipUsluge.SelectedIndex == -1) 
            {
                UcRezervacija.cbTipUsluge.BackColor = Color.LightSalmon;
                uspesno = false;
            }
            else
            {
                UcRezervacija.cbTipUsluge.BackColor = Color.White;
            }
            if (UcRezervacija.cbUsluga.SelectedIndex == -1)
            {
                UcRezervacija.cbUsluga.BackColor = Color.LightSalmon;
                uspesno = false;
            }
            else
            {
                UcRezervacija.cbUsluga.BackColor = Color.White;
            }
            if (UcRezervacija.cbZaposleni.SelectedIndex == -1)
            {
                UcRezervacija.cbZaposleni.BackColor = Color.LightSalmon;
                uspesno = false;
            }
            else
            {
                UcRezervacija.cbZaposleni.BackColor = Color.White;
            }
            if (UcRezervacija.dateTimePickerDatum.Value < DateTime.Now.Date)
            {
                UcRezervacija.dateTimePickerDatum.CalendarForeColor = Color.LightSalmon;
                uspesno = false;
            }
            else
            {
                UcRezervacija.dateTimePickerDatum.CalendarForeColor = Color.White;
            }
            return uspesno;
        }
    }
}
