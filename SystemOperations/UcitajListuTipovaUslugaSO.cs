using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuTipovaUslugaSO : SystemOperationBase
    {
        public List<TipUsluge> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new TipUsluge()).OfType<TipUsluge>().ToList();
        }
    }
}
