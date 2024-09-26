using Common.Domen;
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
    public class UcZaposleniController
    {
        public UcZaposleni UcZaposleni { get; set; }
        private BindingList<Zaposleni> zaposleni;
        private BindingList<TipUsluge> tipoviUsluga;
        public Zaposleni Izabran { get; set; }
        public async Task<UcZaposleni> CreateUserControlAsync()
        {
            UcZaposleni = new UcZaposleni();
            try
            {
                zaposleni = new BindingList<Zaposleni>(await Communication.Instance.UcitajListuZaposlenih());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            UcZaposleni.dgvZaposleni.DataSource = zaposleni;
            UcZaposleni.dgvZaposleni.Columns["IDZaposleni"].Visible = false;
            UcZaposleni.dgvZaposleni.Columns["Username"].Visible = false;
            UcZaposleni.dgvZaposleni.Columns["Password"].Visible = false;

            UcZaposleni.cbTipoviUsluga.DataSource = await Communication.Instance.UcitajListuTipovaUsluga();

            UcZaposleni.btnIzmeniZaposlenog.Click += btnIzmeniZaposlenog_Click;
            UcZaposleni.btnDodajtip.Click += btnDodajtip_Click;
            UcZaposleni.btnIzbrisiTip.Click += btnIzbrisiTip_Click;
            UcZaposleni.btnSacuvajIzmene.Click += btnSacuvajIzmene_Click;


            return UcZaposleni;
        }

        private async void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
          
            Izabran.Telefon = UcZaposleni.txtTelefon.Text;
            Izabran.Adresa = UcZaposleni.txtAdresa.Text;
            Izabran.TipoviUsluga = tipoviUsluga.ToList();
            try
            {
                await Communication.Instance.IzmeniZaposlenog(Izabran);
                MessageBox.Show("Sistem je zapamtio zaposlenog.");
            }catch(Exception ex)
            {
                MessageBox.Show("Sistem ne može da zapamti zaposlenog." + ex.Message);
            }
        }

        private void btnIzbrisiTip_Click(object sender, EventArgs e)
        {
            if (UcZaposleni.dgvTipoviUsluga.SelectedRows.Count == 0) {
                MessageBox.Show("Morate selektovati red tipa usluge.");
                return;
            }
            TipUsluge izabran = (TipUsluge)UcZaposleni.dgvTipoviUsluga.SelectedRows[0].DataBoundItem;
            tipoviUsluga.Remove(izabran);
            UcZaposleni.dgvTipoviUsluga.Refresh();
        }

        private void btnDodajtip_Click(object sender, EventArgs e)
        {
            if (UcZaposleni.cbTipoviUsluga.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati tip usluge iz padajuće liste.");
                return;
            }
            
            TipUsluge tu = (TipUsluge)UcZaposleni.cbTipoviUsluga.SelectedItem;
            if(tipoviUsluga.Contains(tu))
            {
                MessageBox.Show("Tip usluge već postoji u listi.");
                return;
            }
            tipoviUsluga.Add(tu);
            UcZaposleni.dgvTipoviUsluga.Refresh();
        }

        private async void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if(UcZaposleni.dgvZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog čije podatke želite da izmenite.");
                return;
            }
          
            Izabran = (Zaposleni)UcZaposleni.dgvZaposleni.SelectedRows[0].DataBoundItem;
            Izabran = await Communication.Instance.UcitajZaposlenog(Izabran);
            UcZaposleni.gbIzmena.Visible = true;
            UcZaposleni.txtIme.Text = Izabran.Ime;
            UcZaposleni.txtPrezime.Text = Izabran.Prezime;
            UcZaposleni.txtAdresa.Text = Izabran.Adresa;
            UcZaposleni.txtTelefon.Text = Izabran.Telefon;


            tipoviUsluga = new BindingList<TipUsluge>(await Communication.Instance.UcitajListuTipovaUslugaPoZaposlenom(Izabran));
            UcZaposleni.dgvTipoviUsluga.DataSource = tipoviUsluga;
            UcZaposleni.dgvTipoviUsluga.Columns["IDTipUsluge"].Visible = false;
            UcZaposleni.dgvTipoviUsluga.Columns["NazivTipaUsluge"].HeaderText = "Naziv";

        }
    }
}
