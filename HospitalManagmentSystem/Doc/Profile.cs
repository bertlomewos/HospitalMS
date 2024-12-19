using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doc
{
    public partial class Profile : Form
    {
        private int DId;
        public Profile(int dId)
        {
            InitializeComponent();
            this.DId = dId;
            this.Load += new EventHandler(this.Profile_Load);
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                // Query to fetch doctor details
                string query = "SELECT DId, Specialization, Email, PhoneNum FROM doctor WHERE DId = @DId";

                // Database connection
                using (MySqlConnection connection = new MySqlConnection("server=localhost;Uid=root;database=hospitalms;port=3306;Pwd=;"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameter for DoctorID
                        command.Parameters.AddWithValue("@DId", DId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display data on the form
                                label1.Text = "DId: " + reader["DId"].ToString();
                                label2.Text = "Specialization: " + reader["Specialization"].ToString();
                                label4.Text = "Email: " + reader["Email"].ToString();
                                label3.Text = "PhoneNum: " + reader["PhoneNum"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No doctor information found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
