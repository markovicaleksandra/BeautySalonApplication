using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuUslugaPoTipuSO : SystemOperationBase
    {
        private TipUsluge tipUsluge;

        public UcitajListuUslugaPoTipuSO(TipUsluge tipUsluge)
        {
            this.tipUsluge = tipUsluge;
        }

        public List<Usluga> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        { 
            Usluga u = (Usluga)entity;
            u.Uslov = $"u.IDTipUsluge = {tipUsluge.IDTipUsluge}";
            Result = repository.GetAllWithCondition(u).OfType<Usluga>().ToList();
        }
    }
}
