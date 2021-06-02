using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using MySql.Data.MySqlClient;

namespace App.Services
{
    class Command
    {
        bool has = false;
        public string message = string.Empty;
        MySqlCommand cmd = new MySqlCommand();
        Connection conn = new Connection();
        MySqlDataReader dr;

        public bool verifylogin(string login, string senha)
        {
            cmd.CommandText = "SELECT * FROM login WHERE user = @user and password = @password";
            cmd.Parameters.AddWithValue("@user", login);
            cmd.Parameters.AddWithValue("@password", senha);

            try {
                cmd.Connection = conn.connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    has = true;
                }
            }
            catch (Exception ex) {
                message = "Error in DataBase"+ex.Message;
            }
            finally { }
            return has;
        }
    }
}
