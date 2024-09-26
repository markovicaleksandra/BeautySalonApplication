using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DatabaseConnection
{
    public class DBConnectionFactory
    {
        private DBConnection connection = new DBConnection();
        //singleton
        private static DBConnectionFactory instance;
        public static DBConnectionFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnectionFactory();
                return instance;
            }
        }
        private DBConnectionFactory() { }
        //fja koja vraca konekciju, singlton je da bismo imali
        //samo jedno stanje koncekcije kroz celu app 

        public DBConnection GetDBConnection()
        {
            //if(Conn.isreaddy)
            connection.OpenConnection();
            return connection;
        }
    }
}
