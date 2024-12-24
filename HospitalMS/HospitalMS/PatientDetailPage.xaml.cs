using HospitalMS.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalMS
{
    public partial class PatientDetailPage : Window
    {
        private int patientId;
        private ConnectionDB connectionDB = new ConnectionDB();

        public PatientDetailPage(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            LoadPatientDetails();
        }

        void LoadPatientDetails()
        {
            string query = "SELECT Name, Age, Disease, Status FROM Patient WHERE PatientID = @PatientID";
            var parameters = new Dictionary<string, object>
            {
                { "PatientID", patientId }
            };

            // Get the patient details from the database
            DataTable patientDetails = connectionDB.GetTable("Patient", "PatientID = @PatientID", parameters);
            if (patientDetails != null && patientDetails.Rows.Count > 0)
            {
                DataRow patientRow = patientDetails.Rows[0];
                // Assuming you have TextBlocks or other UI elements for these fields
                PatientIdTextBlock.Text = $"Patient ID: {patientRow["PatientID"]}";
                NameTextBlock.Text = $"Name: {patientRow["Name"]}";
                AgeTextBlock.Text = $"Age: {patientRow["Age"]}";
                DiseaseTextBlock.Text = $"Disease: {patientRow["Disease"]}";
                StatusTextBlock.Text = $"Status: {patientRow["Status"]}";
            }
            else
            {
                MessageBox.Show("No patient details found or an error occurred.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
