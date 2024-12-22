using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace HospitalMS
{
    public partial class DoctorPage : Window
    {
        private DataTable patientsTable;
        private int DId;

        public DoctorPage()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            string query = "SELECT PatientID, Name, RoomNumber, Status FROM patients WHERE DoctorID = @DoctorID";
            try
            {
                using (MySqlConnection connection = dbconnection.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DId); // Replace with the actual doctor ID
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        patientsTable = new DataTable();
                        adapter.Fill(patientsTable);
                        PatientsDataGrid.ItemsSource = patientsTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for searching patients
        private void SearchPatients_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string searchQuery = txtSearchPatients.Text.ToLower();
            var filteredRows = patientsTable.Select($"Name LIKE '%{searchQuery}%'");
            DataTable filteredTable = patientsTable.Clone();
            foreach (var row in filteredRows)
            {
                filteredTable.ImportRow(row);
            }
            PatientsDataGrid.ItemsSource = filteredTable.DefaultView;
        }

        // Event handler for filtering patients by status
        private void FilterPatientsByStatus(object sender, RoutedEventArgs e)
        {
            if (patientsTable == null)
            {
                // Handle the null case appropriately
                MessageBox.Show("Patients table is not initialized.");
                return;
            }

            var selectedItem = comboFilterStatus.SelectedItem as ComboBoxItem;
            string selectedStatus = selectedItem?.Content.ToString();

            if (string.IsNullOrEmpty(selectedStatus))
                return;

            DataView filteredView = patientsTable.DefaultView;
            // Filter the patients based on the selected status
            filteredView.RowFilter = $"Status = '{selectedStatus}'";
            PatientsDataGrid.ItemsSource = filteredView;
        }


        // Event handler for View Details button click
        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic to view patient details
            MessageBox.Show("View details functionality to be implemented.");
        }

        // Event handler for Prescribe Medication button click
        private void PrescribeMedication_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for prescribing medication
            MessageBox.Show("Prescribe medication functionality to be implemented.");
        }

        // Event handler for Request Lab Test button click
        private void RequestLabTest_Click(object sender, RoutedEventArgs e)
        {
            // Implement logic for requesting a lab test
            MessageBox.Show("Request lab test functionality to be implemented.");
        }
    }
}
