using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Data
{
    internal class Database
    {
        MySqlConnection sqlConnection = new MySqlConnection(@"Server=DESKTOP-J2R10TA;Database=ProductsDB;Uid=myUsername;Pwd=myPassword;");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}

