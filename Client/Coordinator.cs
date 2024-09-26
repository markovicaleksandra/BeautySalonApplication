using Common.Domen;
using KorisnickiInterfejs.GUIController;
using KorisnickiInterfejs.Helpers;
using KorisnickiInterfejs.ServerCommunication;
using KorisnickiInterfejs.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public class Coordinator
    {

        //mora da ima promenljivu za svakog GUIkontrolera
        
        private FrmMainController frmMainController;
        private FrmLoginController frmLoginController;
        private UcDodajIzmeniKlijentaController ucDodajIzmeniKlijentaController;
        private UcKlijentiController ucKlijentiController;
        private UcPretragaKlijentaController ucPretragaKlijentaController;
        private UcUslugeController ucUslugeController;
        private UcDodajIzmeniUsluguController ucDodajIzmeniUsluguController;
        private UcSveUslugeController ucSveUslugeController;
        private UcSveRezervacijeController ucSveRezervacijeController;
        private UcRezervacijaController ucRezervacijaController;
        private UcZaposleniController ucZaposleniController;
        public FrmLogin FrmLogin { get; set; }
        public FrmMain FrmMain { get; set; }
       // public UcKlijenti  UcKlijenti { get; set; }
         
        //SINGLTON
        private static Coordinator instance;
        public static Coordinator Instance
        {
            get
            {
                if (instance == null) instance = new Coordinator();
                return instance;
            }
        }
        private Coordinator() {
            frmMainController = new FrmMainController();
            frmLoginController = new FrmLoginController();
            ucDodajIzmeniKlijentaController = new UcDodajIzmeniKlijentaController();
            ucKlijentiController = new UcKlijentiController();
            ucPretragaKlijentaController = new UcPretragaKlijentaController();
            ucUslugeController = new UcUslugeController();
            ucDodajIzmeniUsluguController = new UcDodajIzmeniUsluguController();
            ucSveUslugeController = new UcSveUslugeController();
            ucSveRezervacijeController = new UcSveRezervacijeController();
            ucRezervacijaController = new UcRezervacijaController();
            ucZaposleniController = new UcZaposleniController();
        }

        public async Task OpenLoginForm()
        {
            try
            {
                await Communication.Instance.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sistem ne moze da se poveze sa serverom!" + ex.Message);
                return;
            }
            FrmLogin = frmLoginController.CreateLoginForm();
            FrmLogin.Show();
        }

        public void OpenMainForm()
        {
            FrmMain = frmMainController.CreateMainForm();
            FrmMain.Show();
        }

        public void ShowUcKlijenti()
        {
            frmMainController.ChangePanel(ucKlijentiController.CreateUserControl());
        }

        public void ShowUcDodajIzmeniKlijenta(FormMode formMode)
        {
            ucKlijentiController.ChangePanel(ucDodajIzmeniKlijentaController.CreateUserControl(formMode));
        }

        public async void ShowUcPretragaKlijenta()
        {
            ucKlijentiController.ChangePanel(await ucPretragaKlijentaController.CreateUserControlAsync());
        }

        public void ShowUcUsluge()
        {
            frmMainController.ChangePanel(ucUslugeController.CreateUserControl());
        }

        public async void ShowUcDodajIzmeniUslugu(FormMode formMode, Usluga usluga)
        {
            ucUslugeController.ChangePanel(await ucDodajIzmeniUsluguController.CreateUserControlAsync(formMode, usluga));
        }

        public async void ShowUcSveUsluge()
        {
            ucUslugeController.ChangePanel(await ucSveUslugeController.CreateUserControlAsync());

        }

        internal async void ShowUcSveRezervacije()
        {
            frmMainController.ChangePanel(await ucSveRezervacijeController.CreateUserControlAsync());
        }

        internal async void ShowUcDodajIzmeniKlijenta(FormMode formMode, Klijent klijent)
        {
            ucKlijentiController.ChangePanel(await ucDodajIzmeniKlijentaController.CreateUserControlAsync(formMode, klijent));
        }

        internal async void ShowUcDodajIzmeniUslugu(FormMode formMode)
        {
            ucUslugeController.ChangePanel(await ucDodajIzmeniUsluguController.CreateUserControlAsync(formMode));
        }

        public async void ShowUcRezervacija(Klijent klijent)
        {
            frmMainController.ChangePanel(await ucRezervacijaController.CreateUserControl(klijent));
        }

        public async void ShowUcZaposleni()
        {
            frmMainController.ChangePanel(await ucZaposleniController.CreateUserControlAsync());
        }
    }
}
