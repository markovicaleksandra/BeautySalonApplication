using Common;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IDbRepository<IEntity> repository;
        //ientity je bilo koja klasa koja nasledjuje Ientity interfejs, a to su moje domenske klase
        public SystemOperationBase()
        {
            repository = new GenericDbRepository();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.Close();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
