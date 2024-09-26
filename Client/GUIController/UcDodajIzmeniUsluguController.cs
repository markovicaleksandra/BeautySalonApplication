using Common.Domen;
using KorisnickiInterfejs.Helpers;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UcDodajIzmeniUsluguController
    {
        public UcDodajIzmeniUslugu UcDodajIzmeniUslugu { get; set; }
        public Usluga IzabranaUsluga { get; set; }
        public async Task<UcDodajIzmeniUslugu> CreateUserControlAsync(FormMode formMode)
        {
            UcDodajIzmeniUslugu = new UcDodajIzmeniUslugu();
            if (formMode == FormMode.Add)
            {
                UcDodajIzmeniUslugu.btnUsluga.Text = "Dodaj uslugu";
                UcDodajIzmeniUslugu.lblNaslov.Text = "Kreiranje nove usluge";
                UcDodajIzmeniUslugu.cbTipUsluge.DataSource = await Communication.Instance.UcitajListuTipovaUsluga();
                UcDodajIzmeniUslugu.btnUsluga.Click += btnDodajUslugu_Click;
            }
            return UcDodajIzmeniUslugu;
        }

        public async Task<UserControl> CreateUserControlAsync(FormMode formMode,Usluga usluga)
        {
           
            UcDodajIzmeniUslugu = new UcDodajIzmeniUslugu();
            UcDodajIzmeniUslugu.cbTipUsluge.DataSource = await Communication.Instance.UcitajListuTipovaUsluga();


            if (formMode == FormMode.Edit)
            {
                UcDodajIzmeniUslugu.btnUsluga.Text = "Izmeni uslugu";
                UcDodajIzmeniUslugu.lblNaslov.Text = "Izmena usluge";
                IzabranaUsluga = usluga;
                UcDodajIzmeniUslugu.txtCena.Text = usluga.Cena.ToString();
                UcDodajIzmeniUslugu.txtNaziv.Text = usluga.Naziv;
                UcDodajIzmeniUslugu.txtTrajanje.Text = usluga.Trajanje.ToString();
                UcDodajIzmeniUslugu.cbTipUsluge.SelectedItem = usluga.TipUsluge;
                
                UcDodajIzmeniUslugu.btnUsluga.Click += btnIzmeniUslugu_Click;

            }
            if (formMode == FormMode.Details)
            {
                UcDodajIzmeniUslugu.btnUsluga.Visible = false;
                UcDodajIzmeniUslugu.lblNaslov.Text = "Detalji: ";
                UcDodajIzmeniUslugu.txtCena.ReadOnly = true;
                UcDodajIzmeniUslugu.txtNaziv.ReadOnly = true;
                UcDodajIzmeniUslugu.txtTrajanje.ReadOnly =true;
                UcDodajIzmeniUslugu.cbTipUsluge.Enabled = false;
                //ucitavamo podatke o usluzi i prikazujemo na poljima
                try
                {
                    IzabranaUsluga = await Communication.Instance.UcitajUslugu(usluga);
                    UcDodajIzmeniUslugu.txtCena.Text = IzabranaUsluga.Cena.ToString();
                    UcDodajIzmeniUslugu.txtNaziv.Text = IzabranaUsluga.Naziv;
                    UcDodajIzmeniUslugu.txtTrajanje.Text = IzabranaUsluga.Trajanje.ToString();
                    UcDodajIzmeniUslugu.cbTipUsluge.SelectedItem = IzabranaUsluga.TipUsluge;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita uslugu." + ex.Message);
                }
            }
            return UcDodajIzmeniUslugu;
        }

        private async void btnIzmeniUslugu_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                IzabranaUsluga.Naziv = UcDodajIzmeniUslugu.txtNaziv.Text;
                IzabranaUsluga.Cena = double.Parse(UcDodajIzmeniUslugu.txtCena.Text);
                IzabranaUsluga.Trajanje = int.Parse(UcDodajIzmeniUslugu.txtTrajanje.Text);
                IzabranaUsluga.TipUsluge = (TipUsluge)UcDodajIzmeniUslugu.cbTipUsluge.SelectedItem;
                try
                {
                    await Communication.Instance.IzmeniUslugu(IzabranaUsluga);
                    MessageBox.Show("Sistem je zapamtio uslugu.");
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da zapamti uslugu." +ex.Message);
                }
            }
        }

        private async void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Usluga usluga = new Usluga()
                {
                    TipUsluge = (TipUsluge)UcDodajIzmeniUslugu.cbTipUsluge.SelectedItem,
                    Naziv = UcDodajIzmeniUslugu.txtNaziv.Text,
                    Cena = double.Parse(UcDodajIzmeniUslugu.txtCena.Text),
                    Trajanje = int.Parse(UcDodajIzmeniUslugu.txtTrajanje.Text)
                };
                try
                {
                    await Communication.Instance.DodajUslugu(usluga);
                    MessageBox.Show("Sistem je zapamtio uslugu.");
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da zapamti uslugu." + ex.Message);
                }
            }

        }

        private void ClearAllFields()
        {
            UcDodajIzmeniUslugu.txtCena.Text = string.Empty;
            UcDodajIzmeniUslugu.txtNaziv.Text = string.Empty;
            UcDodajIzmeniUslugu.txtTrajanje.Text = string.Empty;
            UcDodajIzmeniUslugu.cbTipUsluge.SelectedIndex = -1;
        }

        private bool IsValid()
        {
            bool uspesno = true;
            // Provera tipa usluge
            if (UcDodajIzmeniUslugu.cbTipUsluge == null)
            {
                UcDodajIzmeniUslugu.cbTipUsluge.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UcDodajIzmeniUslugu.cbTipUsluge.BackColor = Color.White;
            }
            // Provera trajanja
            if (!int.TryParse(UcDodajIzmeniUslugu.txtTrajanje.Text, out int trajanje) || trajanje <= 0)
            {
                UcDodajIzmeniUslugu.txtTrajanje.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UcDodajIzmeniUslugu.txtTrajanje.BackColor = Color.White;
            }
            // Provera cene
            if (!double.TryParse(UcDodajIzmeniUslugu.txtCena.Text, out double cena) || cena <= 0)
            {
                UcDodajIzmeniUslugu.txtCena.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UcDodajIzmeniUslugu.txtCena.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(UcDodajIzmeniUslugu.txtNaziv.Text))
            {
                UcDodajIzmeniUslugu.txtNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UcDodajIzmeniUslugu.txtNaziv.BackColor = Color.White;
            }
            return uspesno;
        }
    }
}
