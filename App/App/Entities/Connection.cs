using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App.Entities
{
    class Connection
    {
        MySqlConnection conn = new MySqlConnection();

        public Connection() {
            conn.ConnectionString = @"Server=localhost;Database=app;Uid=root;Pwd=sous12345;";
        }

        public MySqlConnection connect() {
            conn.Open();

            return conn;
        }
        public void disconnect()
        {
            conn.Close();
        }
    }
}
