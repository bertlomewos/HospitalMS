using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Role { 
    
    Doctor = 1,
    Nurese = 2
}


namespace HospitalMS.UI
{
    class ConnectionDB
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public ConnectionDB()
        {
            connectionString = "Server=localhost;Database=hospitalms;Uid=root;Pwd=;"; // Update with your XAMPP database credentials
        }

        // Method to set a table (insert a row into the table)
        public bool SetTable(string tableName, Dictionary<string, object> columnValues)
        {   
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string columns = string.Join(", ", columnValues.Keys);
                    string parameters = string.Join(", ", columnValues.Keys.Select(key => "@" + key));

                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        foreach (var pair in columnValues)
                        {
                            command.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }

                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Method to get a single row from the table
        public DataTable GetTable(string tableName, string whereCondition, Dictionary<string, object> parameters)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName} WHERE {whereCondition}";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        foreach (var pair in parameters)
                        {
                            command.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return null;
        }
    }
}

