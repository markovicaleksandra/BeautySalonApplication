using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEntity
    {
        //ovo sluzi kad se prave upiti
        string TableName { get; }
        string TableAlias { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        string WhereCondition { get; }
        string GeneralCondition { get; }
        string SelectValues { get; }
        string UpdateValues { get; }
        string InsertValues { get; }

        List<IEntity> GetList(SqlDataReader reader);
        IEntity GetOne(SqlDataReader reader);
    }
}
