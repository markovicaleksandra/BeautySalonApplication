using Common;
using Repository.DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericDbRepository : IDbRepository<IEntity>
    {
        public void Close()
        {
            DBConnectionFactory.Instance.GetDBConnection().Close();
        }

        public void Commit()
        {
            DBConnectionFactory.Instance.GetDBConnection().Commit();
        }

        public void Delete(IEntity entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"delete from {entity.TableName} " +
                $"where {entity.WhereCondition}");
            if(cmd.ExecuteNonQuery() == 0)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select {entity.SelectValues} from {entity.TableName}" +
                $" as {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetList(reader);
            reader.Close();
            return result;
        }

        public List<IEntity> GetAllWithCondition(IEntity entity)
        {
            List<IEntity> result;

            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select {entity.SelectValues} from {entity.TableName} as {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.GeneralCondition}");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetList(reader);
            reader.Close();
            return result;
        }

        public IEntity GetSpecific(IEntity entity)
        {
            IEntity result;
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"select {entity.SelectValues} from {entity.TableName} as {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.WhereCondition};");
            SqlDataReader reader = cmd.ExecuteReader();
            result = entity.GetOne(reader);
            reader.Close();
            return result;
        }

        public void Rollback()
        {
            DBConnectionFactory.Instance.GetDBConnection().Rollback();
        }

        public void Save(IEntity entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"insert into {entity.TableName} values ({entity.InsertValues})");
            if(cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Update(IEntity entity)
        {
            SqlCommand cmd = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"update {entity.TableName} set " +
                $"{entity.UpdateValues} where {entity.WhereCondition}");
            if(cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}
