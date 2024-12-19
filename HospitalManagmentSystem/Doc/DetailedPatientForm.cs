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
using System.Xml;

namespace Doc
{
    public partial class DetailedPatientForm : Form
    {
        private int patientId;

        public DetailedPatientForm(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.Load += new System.EventHandler(this.DetailedPatientForm_Load);

        }

        private void DetailedPatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Name, Age, BloodGroup, Disease FROM patient WHERE PatientID = @PatientID";
                using (MySqlConnection connection = new MySqlConnection("server=localhost;Uid=root;database=hospitalms;port=3306;Pwd=;"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                label1.Text = "Name: " + reader["Name"].ToString();
                                label4.Text = "Age: " + reader["Age"].ToString();
                                label3.Text = "BloodGroup: " + reader["BloodGroup"].ToString();
                                label2.Text = "Disease: " + reader["Disease"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No patient data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            PrescriptionsForm prescribeForm = new PrescriptionsForm(patientId);
            prescribeForm.ShowDialog();
        }
    }
}

