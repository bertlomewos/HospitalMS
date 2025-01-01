/*using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace HospitalMS
{
    class MainDbFunction
    {
       
        public SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-6D8AGEG1;Database=HMS;Integrated Security=True;TrustServerCertificate=True;";

            return con;
        }

        public DataSet getData(string query)
        {
            SqlConnection con =  GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText= query;
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);


            return ds;
        }

        public void setData(string query,string msg)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;
            conn.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(msg, "information", MessageBoxButton.OK, MessageBoxImage.Information);



        }



    }
}*/
using System;
using System.Data;
using System.Windows;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient; // MySQL library

namespace HospitalMS
{
    class MainDbFunction
    {
        // Method to get a database connection
        public MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=hospitalms;Uid=root;Pwd=;";
            return con;
        }

        // Method to retrieve data
        public DataSet getData(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(ds); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return ds;
        }

       
        public void setData(string query, string msg)
        {
            try
            {
                using (MySqlConnection con = GetConnection())
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery(); // Execute the query
                    }
                }
                MessageBox.Show(msg, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

