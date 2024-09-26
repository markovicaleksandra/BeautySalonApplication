using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajUsluguSO : SystemOperationBase
    {
        public Usluga  Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = (Usluga)repository.GetSpecific(entity);
        }
    }
}
