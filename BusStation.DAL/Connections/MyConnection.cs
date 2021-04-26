using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusStation.DAL.Connections
{
    public class MyConnection
    {
        private readonly string _connectionString;
        public MyConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection ConnectToDatabase()
        {
            return new(_connectionString);
        }
    }
}
