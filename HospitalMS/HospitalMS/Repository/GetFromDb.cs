using HospitalMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Repository
{
    class GetFromDb
    {
        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            string GetQuery = "SELECT * FROM users";
            using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
            {
                MySqlCommand GetCommand = new MySqlCommand(GetQuery, connection);
                connection.Open();
                MySqlDataReader reader = GetCommand.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User(
                            (int)reader["ID"],
                            reader["Fname"].ToString(),
                            reader["Lname"].ToString(),
                            reader["Password"].ToString(),
                            reader["Role"].ToString(),
                            (int)reader["Age"],
                            reader["Sex"].ToString(),
                            reader["FIN"].ToString()
                        ));

                }
                return users;
            }
        }
        /*public List<Doc> GetDoc()
        {
            List<Doc> docs = new List<Doc>();
            string GetQuery = "SELECT * FROM doctors";
            using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
            {
                MySqlCommand GetCommand = new MySqlCommand(GetQuery, connection);
                connection.Open();
                MySqlDataReader reader = GetCommand.ExecuteReader();
                while (reader.Read())
                {
                    docs.Add(new Doc(
                            ));
                }
        }*/

    }
}
