using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajListuZaposlenihSO : SystemOperationBase
    {
        public List<Zaposleni> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll((Zaposleni)entity).OfType<Zaposleni>().ToList();
        }
    }
}
