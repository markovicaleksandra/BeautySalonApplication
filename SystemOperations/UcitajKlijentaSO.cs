using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajKlijentaSO : SystemOperationBase
    {
        public Klijent  Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = (Klijent)repository.GetSpecific(entity);
        }
    }
}
