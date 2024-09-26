using Common.Domen;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class FrmLoginController
    {
        public FrmLogin FrmLogin { get; set; }

        public FrmLogin CreateLoginForm()
        {
            FrmLogin = new FrmLogin();
            FrmLogin.StartPosition = FormStartPosition.CenterScreen;
          
            FrmLogin.btnLogin.Click += btnLogin_Click;
            return FrmLogin;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            try
            {
                Zaposleni zaposleni = new Zaposleni
                {
                  Username = FrmLogin.txtUsername.Text,
                  Password = FrmLogin.txtPassword.Text
                };
                zaposleni = await Communication.Instance.Login(zaposleni);
                if (zaposleni != null)
                {
                    MessageBox.Show("Uspešna prijava!");
                    Coordinator.Instance.OpenMainForm();
                    FrmLogin.Dispose();
                }
                else
                {
                    MessageBox.Show("Ne postoji zaposleni sa unetim kredencijalima!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValid()
        {
            bool uspesno = true;
            if (string.IsNullOrEmpty(FrmLogin.txtPassword.Text))
            {
                uspesno = false;
                FrmLogin.txtPassword.BackColor = Color.Salmon;
            }
            else
            {
                FrmLogin.txtPassword.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(FrmLogin.txtUsername.Text))
            {
                uspesno = false;
                FrmLogin.txtUsername.BackColor = Color.Salmon;
            }
            else
            {
                FrmLogin.txtUsername.BackColor = Color.White;
            }
            return uspesno;
        }
    }
}
