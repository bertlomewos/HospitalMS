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
    /// <summary>
    /// Interaction logic for DoctorPage.xaml
    /// </summary>
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
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", loggedInDoctorId); // Replace with the actual doctor ID
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
    }
}
