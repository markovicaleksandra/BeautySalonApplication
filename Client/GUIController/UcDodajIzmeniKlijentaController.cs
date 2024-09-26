using Common.Domen;
using KorisnickiInterfejs.Helpers;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KorisnickiInterfejs.GUIController
{
    public class UcDodajIzmeniKlijentaController
    {
        public UCDodajIzmeniKlijenta UCDodajIzmeniKlijenta { get; set; }
        public Klijent IzabranKlijent { get; private set; }
        public UCDodajIzmeniKlijenta CreateUserControl(FormMode formMode)
        {
            UCDodajIzmeniKlijenta = new UCDodajIzmeniKlijenta();
            if(formMode == FormMode.Add)
            {
                UCDodajIzmeniKlijenta.btnKlijent.Text = "Dodaj klijenta";
                UCDodajIzmeniKlijenta.lblNaslov.Text = "Novi klijent";
                UCDodajIzmeniKlijenta.btnKlijent.Click += btnDodajKlijenta_Click;
            } 


            return UCDodajIzmeniKlijenta;
        }

        public async Task<UCDodajIzmeniKlijenta> CreateUserControlAsync(FormMode formMode, Klijent klijent)
        {
            UCDodajIzmeniKlijenta = new UCDodajIzmeniKlijenta();
            if (formMode == FormMode.Edit)
            {
                UCDodajIzmeniKlijenta.btnKlijent.Text = "Izmeni klijenta";
                UCDodajIzmeniKlijenta.lblNaslov.Text = "Izmena klijenta";
                IzabranKlijent = klijent;
                UCDodajIzmeniKlijenta.txtIme.Text = IzabranKlijent.Ime;
                UCDodajIzmeniKlijenta.txtPrezime.Text = IzabranKlijent.Prezime;
                UCDodajIzmeniKlijenta.txtEmail.Text = IzabranKlijent.Email;
                UCDodajIzmeniKlijenta.txtTelefon.Text = IzabranKlijent.Telefon;

                UCDodajIzmeniKlijenta.btnKlijent.Click += btnIzmeniKlijenta_Click;
            }
            if(formMode == FormMode.Details)
            {
                UCDodajIzmeniKlijenta.btnKlijent.Visible = false;
                UCDodajIzmeniKlijenta.lblNaslov.Text = "Detalji:";
                UCDodajIzmeniKlijenta.txtIme.ReadOnly = true;
                UCDodajIzmeniKlijenta.txtPrezime.ReadOnly = true;
                UCDodajIzmeniKlijenta.txtTelefon.ReadOnly = true;
                UCDodajIzmeniKlijenta.txtEmail.ReadOnly = true;
                //ucitavamo podatke o klijentu i prikazujemo na poljima
                try
                {
                    IzabranKlijent = await Communication.Instance.UcitajKlijenta(klijent);
                    UCDodajIzmeniKlijenta.txtIme.Text = IzabranKlijent.Ime;
                    UCDodajIzmeniKlijenta.txtPrezime.Text = IzabranKlijent.Prezime;
                    UCDodajIzmeniKlijenta.txtTelefon.Text = IzabranKlijent.Telefon;
                    UCDodajIzmeniKlijenta.txtEmail.Text = IzabranKlijent.Email;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sistem ne može da učita klijenta." + ex.Message);
                }
            }
            return UCDodajIzmeniKlijenta;
        }

        private async void btnIzmeniKlijenta_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                IzabranKlijent.Ime = UCDodajIzmeniKlijenta.txtIme.Text;
                IzabranKlijent.Prezime = UCDodajIzmeniKlijenta.txtPrezime.Text;
                IzabranKlijent.Telefon = UCDodajIzmeniKlijenta.txtTelefon.Text;
                IzabranKlijent.Email  = UCDodajIzmeniKlijenta.txtEmail.Text;

                try
                {
                    await Communication.Instance.IzmeniKlijenta(IzabranKlijent);
                    MessageBox.Show("Sistem je zapamtio klijenta.");
                    ClearAllFields();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sistem ne može da zapamti klijenta.");
                }
            }
        }

        private void ClearAllFields()
        {
            UCDodajIzmeniKlijenta.txtIme.Text = string.Empty;
            UCDodajIzmeniKlijenta.txtPrezime.Text = string.Empty;
            UCDodajIzmeniKlijenta.txtEmail.Text = string.Empty;
            UCDodajIzmeniKlijenta.txtTelefon.Text = string.Empty;
        }

        private async void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Klijent klijent = new Klijent()
                {
                    Ime = UCDodajIzmeniKlijenta.txtIme.Text,
                    Prezime = UCDodajIzmeniKlijenta.txtPrezime.Text,
                    Telefon = UCDodajIzmeniKlijenta.txtTelefon.Text,
                    Email = UCDodajIzmeniKlijenta.txtEmail.Text
                };
                try
                {
                    await Communication.Instance.DodajKlijenta(klijent);
                    MessageBox.Show("Sistem je zapamtio klijenta.");
                    ClearAllFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sistem ne može da zapamti klijenta." + ex.Message);
                }
            }
        }

        private bool IsValid()
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(UCDodajIzmeniKlijenta.txtIme.Text))
            {
                UCDodajIzmeniKlijenta.txtIme.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UCDodajIzmeniKlijenta.txtIme.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(UCDodajIzmeniKlijenta.txtPrezime.Text))
            {
                UCDodajIzmeniKlijenta.txtPrezime.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                UCDodajIzmeniKlijenta.txtPrezime.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(UCDodajIzmeniKlijenta.txtEmail.Text))
            {
                UCDodajIzmeniKlijenta.txtEmail.BackColor = Color.Salmon;
                uspesno = false;
            }
            else if (!UCDodajIzmeniKlijenta.txtEmail.Text.Contains("@"))
            {
                UCDodajIzmeniKlijenta.txtEmail.BackColor = Color.Salmon;
                UCDodajIzmeniKlijenta.lblValidacija.Text = "E-mail adresa nije validna.";
                uspesno = false;
            }
            else
            {
                UCDodajIzmeniKlijenta.lblValidacija.Text = string.Empty;
                UCDodajIzmeniKlijenta.txtEmail.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(UCDodajIzmeniKlijenta.txtTelefon.Text))
            {
                UCDodajIzmeniKlijenta.txtTelefon.BackColor = Color.Salmon;
                uspesno = false;
            }
            else if (!UCDodajIzmeniKlijenta.txtTelefon.Text.All(char.IsDigit))
            {
                UCDodajIzmeniKlijenta.txtTelefon.BackColor = Color.Salmon;
                UCDodajIzmeniKlijenta.lblValidacija.Text = "Telefon mora sadržati samo brojeve.";
                uspesno = false;
            }
            else
            {
                UCDodajIzmeniKlijenta.lblValidacija.Text = string.Empty;
                UCDodajIzmeniKlijenta.txtTelefon.BackColor = Color.White;
            }
            return uspesno;
        }
    }
}
