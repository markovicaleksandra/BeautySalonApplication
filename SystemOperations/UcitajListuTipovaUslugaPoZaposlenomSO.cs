using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuTipovaUslugaPoZaposlenomSO : SystemOperationBase
    {
        private Zaposleni zaposleni;

        public UcitajListuTipovaUslugaPoZaposlenomSO(Zaposleni zaposleni)
        {
            this.zaposleni = zaposleni;
        }

        public List<TipUsluge> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            TipUsluge t = (TipUsluge)entity;
            t.Uslov = $"zr.IDZaposleni = {zaposleni.IDZaposleni}";
            Result = repository.GetAllWithCondition(t).OfType<TipUsluge>().ToList();
        }
    }
}
