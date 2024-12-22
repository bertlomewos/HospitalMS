using System;
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
}
