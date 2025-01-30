using HospitalMS.Model;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
        public string Insertfin(finance finance)
        {
            int UID = int.Parse(InsertUser(finance));
            string insertQuery = "INSERT INTO finance " +
                "(Id) VALUES " +
                "(@Id)";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
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
        

        public string InsertNurse(Nurse nurse)
        {
            int UID = int.Parse(InsertUser(nurse));
            string insertQuery = "INSERT INTO nurse " +
                "(ID) VALUES " +
                "(@Id);";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
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
        public string InsertPatient(Patient patient, int DoctorID)
        {
            string insertQuery = "INSERT INTO patient " +
                "(Name, FName, Age, Sex, Disease, FIN, DoctorID) VALUES " +
                "(@Name, @FName, @Age, @Sex, @Disease, @FIN, @DoctorID);";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DbConnection.connectionString))
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Name", patient.Name);
                    insertCommand.Parameters.AddWithValue("@FName", patient.FatherName);
                    insertCommand.Parameters.AddWithValue("@Age", patient.Age);
                    insertCommand.Parameters.AddWithValue("@Sex", patient.Sex);
                    insertCommand.Parameters.AddWithValue("@Disease", patient.Disease);
                    insertCommand.Parameters.AddWithValue("@FIN", patient.FIN);
                    insertCommand.Parameters.AddWithValue("@DoctorID", DoctorID); 
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                return e.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Successful";
        }

    }
}
