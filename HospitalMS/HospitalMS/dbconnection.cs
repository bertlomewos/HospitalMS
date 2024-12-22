using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;


namespace HospitalMS
{
    public static class dbconnection
    {
        private static readonly string ConnectionString = "server=localhost;Uid=root;database=hospitalms;port=3306;Pwd=;";

    }
    public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception($"Database Connection Error: {ex.Message}");
            }
            return connection;
        }

        // Method to close the connection (if needed explicitly)
        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        }
    }
