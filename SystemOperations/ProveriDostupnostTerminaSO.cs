using Common;
using Common.Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class ProveriDostupnostTerminaSO : SystemOperationBase
    {
        public bool Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Rezervacija r = (Rezervacija)entity;
            /*r.Uslov = $"r.IDZaposleni = {r.Zaposleni.IDZaposleni} AND r.Datum = '{r.Datum.ToString("yyyy-MM-dd")}' AND " +
                $"((CAST(r.VremePocetka AS TIME) >= '{r.VremePocetka.ToString("HH:mm:ss")}' AND CAST(r.VremePocetka AS TIME) < '{r.VremeZavrsetka.ToString("HH:mm:ss")}') " +
                $"OR (CAST(r.VremeZavrsetka AS TIME) > '{r.VremePocetka.ToString("HH:mm:ss")}' AND CAST(r.VremeZavrsetka AS TIME) <= '{r.VremeZavrsetka.ToString("HH:mm:ss")}') OR" +
                $" (CAST(r.VremePocetka AS TIME) <= '{r.VremePocetka.ToString("HH:mm:ss")}' AND CAST(r.VremeZavrsetka AS TIME) >= '{r.VremeZavrsetka.ToString("HH:mm:ss")}') OR" +
                $" (CAST(r.VremePocetka AS TIME) <= '{r.VremePocetka.ToString("HH:mm:ss")}' AND CAST(r.VremeZavrsetka AS TIME) > '{r.VremeZavrsetka.ToString("HH:mm:ss")}'))";*/
            r.Uslov = $@"r.IDZaposleni = {r.Zaposleni.IDZaposleni} AND r.Datum = '{r.Datum.ToString("yyyy-MM-dd")}' AND 
(
    ('{r.VremePocetka.ToString("HH:mm:ss")}' BETWEEN CAST(r.VremePocetka AS TIME) AND CAST(r.VremeZavrsetka AS TIME)) OR
    ('{r.VremeZavrsetka.ToString("HH:mm:ss")}' BETWEEN CAST(r.VremePocetka AS TIME) AND CAST(r.VremeZavrsetka AS TIME)) OR
    (CAST(r.VremePocetka AS TIME) >= '{r.VremePocetka.ToString("HH:mm:ss")}'  AND
    CAST(r.VremeZavrsetka AS TIME) <= '{r.VremeZavrsetka.ToString("HH:mm:ss")}')
)";
            int brojRez = repository.GetAllWithCondition(r).OfType<Rezervacija>().Count();
            //ako je rezultat veci od 0, termin je zauzet
            if(brojRez > 0)
            {
                //termin je zauzet
                Result = true;
            }
            else
            {
                Result = false;
            }
        }
    }
}
