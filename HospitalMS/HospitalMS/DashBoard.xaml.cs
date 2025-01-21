using HospitalMS.Model;
using HospitalMS.Repository;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HospitalMS
{
    /// <summary>
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Page
    {

        public DashBoard()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            List<Patient> users = MainWindow.PatientsHolder;
            UserData.ItemsSource = users;

            List<Patient> patients = MainWindow.PatientsHolder;
            UserData.ItemsSource = patients;
        }

    }
}
