using HospitalMS.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Repository
{
    internal class SendToDb
    {
        public string InsertUser(User user)
        {
            string insertQuery = "INSERT INTO users " +
                "(Password, Role, Fname, Lname, Age, Sex, FIN) VALUES " +
                "(@Password, @Role, @Fname, @Lname, @Age, @sex, @FIN); SELECT LAST_INSERT_ID();";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Password", user.Password);
                    insertCommand.Parameters.AddWithValue("@Role", user.Role);
                    insertCommand.Parameters.AddWithValue("@Fname", user.FName);
                    insertCommand.Parameters.AddWithValue("@Lname", user.LName);
                    insertCommand.Parameters.AddWithValue("@Age", user.Age);
                    insertCommand.Parameters.AddWithValue("@sex", user.Sex);
                    insertCommand.Parameters.AddWithValue("@FIN", user.FIN);
                    connection.Open();
                    user.Id = Convert.ToInt32(insertCommand.ExecuteScalar());
                }

            }
            catch (Exception ex) 
            {
                return ex.Message;
            }

          return user.Id.ToString();
        }

        public string InsertDoc(Doc doc)
        {
            int UID = int.Parse(InsertUser(doc));
            string insertQuery = "INSERT INTO doctor " +
                "(Specialization, ID) VALUES " +
                "(@Specialization, @Id);";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Specialization", doc.Specialization);
                    insertCommand.Parameters.AddWithValue("@Id", UID);
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Successfull";
        }

    }
}
