using Common;
using Common.Domen;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemOperations;

namespace Server
{
    public class Controller
    {
        private IDbRepository<IEntity> repository;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() {
            repository = new GenericDbRepository();
        }

        public Zaposleni Login(Zaposleni z)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(z);
            return so.Result;
        }

        public List<TipUsluge> UcitajListuTipovaUsluga()
        {
            UcitajListuTipovaUslugaSO so = new UcitajListuTipovaUslugaSO();
            so.ExecuteTemplate(new TipUsluge());
            return so.Result;
        }

        public void DodajUslugu(Usluga u)
        {
            DodajUsluguSO so = new DodajUsluguSO();
            so.ExecuteTemplate(u);
        }

        public void DodajKlijenta(Klijent k)
        {
            DodajKlijentaSO so = new DodajKlijentaSO();
            so.ExecuteTemplate(k);
        }

        public List<Klijent> UcitajListuKlijenata()
        {
            UcitajListuKlijenataSO so = new UcitajListuKlijenataSO();
            so.ExecuteTemplate(new Klijent());
            return so.Result;
        }

        public void IzmeniKlijenta(Klijent k)
        {
            IzmeniKlijentaSO so = new IzmeniKlijentaSO();
            so.ExecuteTemplate(k);
        }

        public List<Klijent> PretraziKlijente(string filter)
        {
            PretraziKlijenteSO so = new PretraziKlijenteSO(filter);
            so.ExecuteTemplate(new Klijent());
            return so.Result;
        }

        public List<Usluga> UcitajListuUsluga()
        {
            UcitajListuUslugaSO so = new UcitajListuUslugaSO();
            so.ExecuteTemplate(new Usluga());
            return so.Result;
        }

        public void IzbrisiUslugu(Usluga usluga)
        {
            IzbrisiUsluguSO so = new IzbrisiUsluguSO();
            so.ExecuteTemplate(usluga);
        }

        public void IzmeniUslugu(Usluga usluga)
        {
            IzmeniUsluguSO so = new IzmeniUsluguSO();
            so.ExecuteTemplate(usluga);
        }

        public List<Usluga> UcitajListuUslugaPoTipu(TipUsluge tipUsluge)
        {
            UcitajListuUslugaPoTipuSO so = new UcitajListuUslugaPoTipuSO(tipUsluge);
            so.ExecuteTemplate(new Usluga());
            return so.Result;
        }

        public List<Zaposleni> UcitajListuZaposlenihPoTipuUsluge(TipUsluge tipUsluge)
        {
            UcitajListuZaposlenihPoTipuUslugeSO so = new UcitajListuZaposlenihPoTipuUslugeSO(tipUsluge);
            so.ExecuteTemplate(new Zaposleni());
            return so.Result;
        }

        public List<Rezervacija> UcitajListuRezervacija()
        {
            UcitajListuRezervacijaSO so = new UcitajListuRezervacijaSO();
            so.ExecuteTemplate(new Rezervacija());
            return so.Result;
        }

        public Klijent UcitajKlijenta(Klijent klijent)
        {
            UcitajKlijentaSO so = new UcitajKlijentaSO();
            so.ExecuteTemplate(klijent);
            return so.Result;
        }

        public Usluga UcitajUslugu(Usluga usluga)
        {
            UcitajUsluguSO so = new UcitajUsluguSO();
            so.ExecuteTemplate(usluga);
            return so.Result;
        }

        public void SacuvajRezervacije(List<Rezervacija> rezervacije)
        {
            SacuvajRezervacijeSO so = new SacuvajRezervacijeSO
            {
                Rezervacije = rezervacije
            };
            so.ExecuteTemplate(new Rezervacija());
        }

        public bool ProveriDostupnostTermina(Rezervacija rezervacija)
        {
            ProveriDostupnostTerminaSO so = new ProveriDostupnostTerminaSO();
            so.ExecuteTemplate(rezervacija);
            return so.Result;
        }

        public void IzbrisiRezervaciju(Rezervacija rezervacija)
        {
            IzbrisiRezervacijuSO so = new IzbrisiRezervacijuSO();
            so.ExecuteTemplate(rezervacija);
        }

        public List<Zaposleni> UcitajListuZaposlenih()
        {
            UcitajListuZaposlenihSO so = new UcitajListuZaposlenihSO();
            so.ExecuteTemplate(new Zaposleni());
            return so.Result;
        }

        public List<TipUsluge> UcitajListuTipovaUslugaPoZaposlenom(Zaposleni zaposleni)
        {
            UcitajListuTipovaUslugaPoZaposlenomSO so = new UcitajListuTipovaUslugaPoZaposlenomSO(zaposleni);
            so.ExecuteTemplate(new TipUsluge());
            return so.Result;
        }

        public void IzmeniZaposlenog(Zaposleni zaposleni)
        {
            IzmeniZaposlenogSO so = new IzmeniZaposlenogSO();
            so.ExecuteTemplate(zaposleni);
        }

        public Zaposleni UcitajZaposlenog(Zaposleni zaposleni)
        {
            UcitajZaposlenogSO so = new UcitajZaposlenogSO();
            so.ExecuteTemplate(zaposleni);
            return so.Result;
        }
    }
}
