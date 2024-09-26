using Common;
using Common.Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class LoginSO : SystemOperationBase
    {
        public Zaposleni Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Zaposleni zaposleni = (Zaposleni)entity;
            foreach(Zaposleni z in repository.GetAll(new Zaposleni()))
            {
                if (zaposleni.Username == z.Username && zaposleni.Password == z.Password)
                    Result = z;
            }
            
        }
    }
}
