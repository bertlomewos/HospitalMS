using MySql.Data.MySqlClient;
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
    public partial class DoctorPage : Window
    {
        private DataTable patientsTable;
        private int DId;

        public DoctorPage(int DId)
        {
            InitializeComponent();
            DId = DId;
            LoadPatients();
            
        }

        private void LoadPatients()
        {
            string query = "SELECT PatientID, Name, RoomNumber, Status FROM patients WHERE DId = @DId";
            try
            {
                
                using (MySqlConnection connection = dbconnection.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DId", DId); // Replace with the actual doctor ID
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

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsDataGrid.SelectedItem is DataRowView selectedRow)
            {
                int patientId = Convert.ToInt32(selectedRow["PatientID"]);

                PatientDetailPage detailsPage = new PatientDetailPage(patientId);
                detailsPage.Show();
            }
            else
            {
                MessageBox.Show("Please select a patient to view details.", "No Patient Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        void RequestLabTest_Click(object sender, RoutedEventArgs e)
        {
            if (PatientsDataGrid.SelectedItem is DataRowView selectedRow)
            {
                int patientId = Convert.ToInt32(selectedRow["PatientID"]);
                // You can implement the logic for requesting a lab test here
                MessageBox.Show($"Lab test requested for Patient ID: {patientId}", "Request Lab Test", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a patient to request a lab test.", "No Patient Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SearchPatients_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = txtSearchPatients.Text.ToLower();
            DataView dataView = patientsTable.DefaultView;
            dataView.RowFilter = $"Name LIKE '%{searchTerm}%' OR RoomNumber LIKE '%{searchTerm}%' OR Status LIKE '%{searchTerm}%'";
            PatientsDataGrid.ItemsSource = dataView;
        }
    }

}

