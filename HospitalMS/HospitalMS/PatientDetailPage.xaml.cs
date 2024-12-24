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
            string query = "SELECT PatientID, Name, Age, Disease, Status FROM Patient WHERE PatientID = @PatientID";
            var parameters = new Dictionary<string, object>
            {
                { "PatientID", patientId }
            };

            // Get the patient details from the database
            DataTable patientDetails = connectionDB.GetTable("Patient", "PatientID = @PatientID", parameters);
           
            if (patientDetails != null && patientDetails.Rows.Count > 0)
            {
                DataRow patientRow = patientDetails.Rows[0];
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

        void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Make the TextBoxes visible for editing
            NameTextBlock.Visibility = Visibility.Collapsed;
            AgeTextBlock.Visibility = Visibility.Collapsed;
            DiseaseTextBlock.Visibility = Visibility.Collapsed;
            StatusTextBlock.Visibility = Visibility.Collapsed;

            NameTextBox.Visibility = Visibility.Visible;
            AgeTextBox.Visibility = Visibility.Visible;
            DiseaseTextBox.Visibility = Visibility.Visible;
            StatusTextBox.Visibility = Visibility.Visible;

            // Show the Save button
            SaveButton.Visibility = Visibility.Visible;
            EditButton.Visibility = Visibility.Collapsed;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the updated values from the TextBoxes
            string updatedName = NameTextBox.Text;
            int updatedAge = int.Parse(AgeTextBox.Text);
            string updatedDisease = DiseaseTextBox.Text;
            string updatedStatus = StatusTextBox.Text;

            // Prepare the update query and parameters
            var columnValues = new Dictionary<string, object>
            {
                { "Name", updatedName },
                { "Age", updatedAge },
                { "Disease", updatedDisease },
                { "Status", updatedStatus },
                { "PatientID", patientId }
            };

            string whereCondition = "PatientID = @PatientID";
            var whereParameters = new Dictionary<string, object>
            {
                { "PatientID", patientId }
            };


            // Execute the update query
            bool result = connectionDB.SetTable("UPDATE", "Patient", columnValues, whereCondition, whereParameters);

            if (result)
            {
                MessageBox.Show("Patient information updated successfully.");

                // Hide the TextBoxes and show the updated details
                NameTextBlock.Text = "Name: " + updatedName;
                AgeTextBlock.Text = "Age: " + updatedAge.ToString();
                DiseaseTextBlock.Text = "Disease: " + updatedDisease;
                StatusTextBlock.Text = "Status: " + updatedStatus;

                // Hide the TextBoxes and Save button, show Edit button
                NameTextBox.Visibility = Visibility.Collapsed;
                AgeTextBox.Visibility = Visibility.Collapsed;
                DiseaseTextBox.Visibility = Visibility.Collapsed;
                StatusTextBox.Visibility = Visibility.Collapsed;

                SaveButton.Visibility = Visibility.Collapsed;
                EditButton.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Failed to update patient information.");
            }
        }

    }
}
