using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using HospitalMS.UI;

namespace HospitalMS
{
    public partial class DoctorPage : Window
    {
        private DataTable PatientsTable = new DataTable(); // Initialize PatientsTable
        private int DId; // Doctor ID
        private ConnectionDB connectionDB = new ConnectionDB();

        public DoctorPage()
        {
            InitializeComponent();
            DId = 1; 
            LoadPatients();
        }
        public DoctorPage(int DId)
        {
            InitializeComponent();
            this.DId = DId;
            LoadPatients();
        }

        private void LoadPatients()
        {
            if (DId == 0) return;

            string query = "SELECT PatientID, Name, Age, Disease FROM Patient WHERE DId = @DId";
            var parameters = new Dictionary<string, object>
                {
                    { "DId", DId }
                };

            DataTable patient = connectionDB.GetTable("Patient", "DId = @DId", parameters);
            if (patient != null && patient.Rows.Count > 0)
            {
                PatientsTable = patient;
                patientsDataGrid.ItemsSource = PatientsTable.DefaultView;
            }
            else
            {
                MessageBox.Show("No patients found or an error occurred.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SearchPatients_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PatientsTable == null) return;

            string searchQuery = (txtSearchpatient.Text?? string.Empty).ToLower();
            var filteredRows = PatientsTable.Select($"Name LIKE '%{searchQuery}%'");
            DataTable filteredTable = PatientsTable.Clone();

            foreach (var row in filteredRows)
            {
                filteredTable.ImportRow(row);
            }

            patientsDataGrid.ItemsSource = filteredTable.DefaultView;
        }

        private void FilterPatientsByStatus(object sender, RoutedEventArgs e)
        {
            if (PatientsTable == null) return;

            var selectedItem = comboFilterStatus.SelectedItem as ComboBoxItem;
            string selectedStatus = selectedItem?.Content.ToString();

            if (string.IsNullOrEmpty(selectedStatus) || selectedStatus == "All")
            {
                patientsDataGrid.ItemsSource = PatientsTable.DefaultView;
                return;
            }

            DataView filteredView = PatientsTable.DefaultView;
            filteredView.RowFilter = $"Status = '{selectedStatus}'";
            patientsDataGrid.ItemsSource = filteredView;
        }

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = patientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);
                MessageBox.Show($"View details for Patient ID: {selectedPatientId}");
                // Implement logic to view patient details
            }
            else
            {
                MessageBox.Show("Please select a patient.");
            }
        }

        private void PrescribeMedication_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = patientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);

                var prescriptionData = new Dictionary<string, object>
                    {
                        { "PatientID", selectedPatientId },
                        { "Medication", "MedName" },
                        { "DId", DId }
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
            DataRowView selectedRow = patientsDataGrid.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int selectedPatientId = Convert.ToInt32(selectedRow["PatientID"]);

                var labTestData = new Dictionary<string, object>
                    {
                        { "PatientID", selectedPatientId },
                        { "TestType", "Blood Test" },
                        { "DId", DId }
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
