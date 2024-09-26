using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuZaposlenihPoTipuUslugeSO : SystemOperationBase
    {
        private TipUsluge tipUsluge;

        public UcitajListuZaposlenihPoTipuUslugeSO(TipUsluge tipUsluge)
        {
            this.tipUsluge = tipUsluge;
        }

        public List<Zaposleni> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Zaposleni z = (Zaposleni)entity;
            z.Uslov = $"zr.IDTipUsluge = {tipUsluge.IDTipUsluge}";
            Result = repository.GetAllWithCondition(z).OfType<Zaposleni>().ToList();
        }
    }
}
