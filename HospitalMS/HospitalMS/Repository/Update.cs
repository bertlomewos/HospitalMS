using HospitalMS.Model;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Repository
{
    class Update
    {
        public string UpdateUser(User user)
        {
            string insertQuery = "UPDATE users set " +
                "Password=@Password, Fname=@Fname, Lname=@Lname, Age=@Age where ID = @ID";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand UpdateCommand = new MySqlCommand(insertQuery, connection);
                    UpdateCommand.Parameters.AddWithValue("@Password", user.Password);
                    UpdateCommand.Parameters.AddWithValue("@Fname", user.FName);
                    UpdateCommand.Parameters.AddWithValue("@Lname", user.LName);
                    UpdateCommand.Parameters.AddWithValue("@Age", user.Age);
                    UpdateCommand.Parameters.AddWithValue("@ID", user.Id);
                    connection.Open();
                    UpdateCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }

            return "Successful";
        }

        public string diagnosePatient(Patient patient)
        {

            string updateQuery = "Update patient set Disease = @Diagnos";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand UpdateCommand = new MySqlCommand(updateQuery, connection);
                    UpdateCommand.Parameters.AddWithValue("@Diagnos", patient.Disease);
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
           return "Daignosed";
        }
    }
}
