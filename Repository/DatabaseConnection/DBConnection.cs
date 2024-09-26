using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseConnection
{
    public class DBConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public void OpenConnection()
        {
            if (!IsReady())
            {
                string connString = ConfigurationManager.ConnectionStrings["ksdb"].ConnectionString;
                // Add MARS parameter to the connection string
                connString += ";MultipleActiveResultSets=True";

                connection = new SqlConnection(connString);
                connection.Open();
            }
        }


        public SqlCommand CreateCommand(string sql = " ")
        {
            if(transaction == null)
            {
                transaction = connection.BeginTransaction();
            }
            return new SqlCommand(sql, connection, transaction);
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }

        private bool IsReady()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }
        public void Close()
        {
            connection?.Close();
            transaction?.Dispose();
            transaction = null;
        }
    }
}
