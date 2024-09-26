using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuRezervacijaSO : SystemOperationBase
    {
        public List<Rezervacija> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll((Rezervacija)entity).OfType<Rezervacija>().ToList();
        }
    }
}
