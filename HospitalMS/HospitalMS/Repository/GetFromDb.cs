﻿using HospitalMS.Model;
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
                    users.Add(new Admin(
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
        public List<Doc> GetDoc()
        {
            List<User> Users = GetUser();
            List<Doc> docs = new List<Doc>();
            string GetQuery = "SELECT * FROM doctors";
            using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
            {
                MySqlCommand GetCommand = new MySqlCommand(GetQuery, connection);
                connection.Open();
                MySqlDataReader reader = GetCommand.ExecuteReader();
                while (reader.Read())
                {
                    foreach (User user in Users)
                    {
                        if (user.Role == "Doctor")
                        {
                            docs.Add(new Doc(
                                (int)reader["ID"],
                                user.FName,
                                user    .LName,
                                user.Password,
                                user.Role,
                                user.Age,
                                user.Sex,
                                user.FIN,
                                (int)reader["DId"],
                                reader["Specialization"].ToString()

                            ));

                        }
                    }
                   
                }
                return docs;
            }

        }
    }
}
