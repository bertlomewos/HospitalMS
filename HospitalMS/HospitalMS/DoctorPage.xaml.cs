using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using HospitalMS.UI;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HospitalMS
{
    public partial class DoctorPage : Window
    {
        private DataTable patientsTable;
        private int DId;
        private ConnectionDB connectionDB = new ConnectionDB();

        public DoctorPage() 
        {
            InitializeComponent();
        }
        public DoctorPage(int doctorId) : this()
        {
            DId = doctorId;
            LoadPatients();
        }
        public DoctorPage(string someParam) : this()
        {
            // Handle the parameter
        }

        private void LoadPatients()
        {
            if (DId == 0) return;
            string query = "SELECT PatientID, Name, RoomNumber, Status FROM patients WHERE DoctorID = @DoctorID";
            var parameters = new Dictionary<string, object>
            {
                { "DoctorID", DId } 
            };

            DataTable patients = connectionDB.GetTable("patients", "DoctorID = @DoctorID", parameters);
            if (patients != null && patients.Rows.Count > 0)
            {
                patientsTable = patients; 
                PatientsDataGrid.ItemsSource = patientsTable.DefaultView;
            }
            else
            {
                MessageBox.Show("No patients found or error occurred.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchPatients_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (patientsTable == null) return;

            string searchQuery = txtSearchPatients.Text.ToLower();
            var filteredRows = patientsTable.Select($"Name LIKE '%{searchQuery}%'");
            DataTable filteredTable = patientsTable.Clone();

            foreach (var row in filteredRows)
            {
                filteredTable.ImportRow(row);
            }

            PatientsDataGrid.ItemsSource = filteredTable.DefaultView;
        }

        private void FilterPatientsByStatus(object sender, RoutedEventArgs e)
        {
            if (patientsTable == null) return;

            var selectedItem = comboFilterStatus.SelectedItem as ComboBoxItem;
            string selectedStatus = selectedItem?.Content.ToString();

            if (string.IsNullOrEmpty(selectedStatus)) return;

            DataView filteredView = patientsTable.DefaultView;
            filteredView.RowFilter = $"Status = '{selectedStatus}'";
            PatientsDataGrid.ItemsSource = filteredView;
        }

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = PatientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                // Retrieve the PatientID from the selected row
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);

                // Implement the logic to view patient details based on selectedPatientId
                MessageBox.Show($"View details for Patient ID: {selectedPatientId}");
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }

        private void PrescribeMedication_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = PatientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                // Retrieve the PatientID from the selected row
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);

                var prescriptionData = new Dictionary<string, object>
                {
                    { "PatientID", selectedPatientId }, 
                    { "Medication", "MedName" }, 
                    { "DoctorID", DId }
                };

                bool result = connectionDB.SetTable("prescriptions", prescriptionData);
                if (result)
                {
                    MessageBox.Show("Medication prescribed successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to prescribe medication.");
                }
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }

        private void RequestLabTest_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = PatientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                // Retrieve the PatientID from the selected row
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);

                var labTestData = new Dictionary<string, object>
                {
                    { "PatientID", selectedPatientId }, // Use the selected patient's ID
                    { "TestType", "Blood Test" }, // Example data
                    { "DoctorID", DId }
                };

                bool result = connectionDB.SetTable("lab_tests", labTestData);
                if (result)
                {
                    MessageBox.Show("Lab test requested successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to request lab test.");
                }
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }
    }
}
