using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class SacuvajRezervacijeSO : SystemOperationBase
    {
        public List<Rezervacija> Rezervacije { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            foreach (Rezervacija r in Rezervacije)
            {
                repository.Save(r);
            }
        }
    }
}
