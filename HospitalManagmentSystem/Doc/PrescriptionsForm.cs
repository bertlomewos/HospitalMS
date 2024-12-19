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
    public partial class PrescriptionsForm : Form
    {
        private int patientId;
        public PrescriptionsForm(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void PrescriptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO prescriptions (PatientID, DId, MedicationName, Dosage, Instructions, Duration) " +
                               "VALUES (@PatientID, @DId, @MedicationName, @Dosage, @Instructions, @Duration)";

                using (MySqlConnection connection = new MySqlConnection("server=localhost;Uid=root;database=hospitalms;port=3306;Pwd=;"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", patientId); 
                        command.Parameters.AddWithValue("@DId", patientId);
                        command.Parameters.AddWithValue("@MedicationName", MedicationName.Text);
                        command.Parameters.AddWithValue("@Dosage", Dosage.Text);
                        command.Parameters.AddWithValue("@Instructions", Instructions.Text);
                        command.Parameters.AddWithValue("@Duration", Duration.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Prescription saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
