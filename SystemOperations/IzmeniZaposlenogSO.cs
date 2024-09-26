using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class IzmeniZaposlenogSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Zaposleni zaposleni = (Zaposleni)entity;
            zaposleni.WhereUslov = $"IDZaposleni = {zaposleni.IDZaposleni}";
            repository.Update(zaposleni);
            //brisanje svih redova u zaposleni radi koji su vezani za datog zaposlenog
            ZaposleniRadi zapRadi = new ZaposleniRadi()
            {
                Zaposleni = zaposleni
            };
            repository.Delete(zapRadi);

            foreach(TipUsluge tu in zaposleni.TipoviUsluga)
            {
                ZaposleniRadi zr = new ZaposleniRadi();
                zr.TipUsluge = tu;
                zr.Zaposleni = zaposleni;
                repository.Save(zr);
            }
        }
    }
}
