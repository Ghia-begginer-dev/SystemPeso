using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SystemPeso.Models
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
            
        }

        public void Insert(string sql)
        {
            MySqlConnection conn = new MySqlConnection(Module.mydbConnection);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public List<UserModel> ReadUsers(string sql)
        {

            List<UserModel> users = new List<UserModel>();
            MySqlConnection conn = new MySqlConnection(Module.mydbConnection);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new UserModel
                {
                    Name = (string)reader["Name"],
                    Approved = (bool)reader["Approved"]
                });
            }
            cmd.Dispose();
            conn.Close();

            return users;
        }
    }
}