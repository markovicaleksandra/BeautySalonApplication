using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class PretraziKlijenteSO : SystemOperationBase
    {
        private string filter;

        public PretraziKlijenteSO(string filter)
        {
            this.filter = filter;
        }

        public List<Klijent> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Klijent k = new Klijent
            {
                Filter = $"Ime like '{filter}%'"
            };
            Result = repository.GetAllWithCondition(k).OfType<Klijent>().ToList();
        }
    }
}
