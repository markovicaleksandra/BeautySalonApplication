using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UcitajZaposlenogSO : SystemOperationBase
    {
        public Zaposleni Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Zaposleni z = (Zaposleni)entity;
            z.WhereUslov= $"z.IDZaposleni = {z.IDZaposleni}";
            Result = (Zaposleni)repository.GetSpecific(entity);

        }
    }
}
