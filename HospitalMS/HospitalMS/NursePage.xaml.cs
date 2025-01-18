using HospitalMS.Model;
using HospitalMS.Repository;
using Org.BouncyCastle.Asn1.X509;
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
    /// Interaction logic for NursePage.xaml
    /// </summary>
    public partial class NursePage : Page
    {
        public NursePage(String role)
        {
            InitializeComponent();
        }

        private void DashboardClicked(object sender, RoutedEventArgs e)
        {
            NurseFrame.Navigate(new DashBoard("Nurse"));
            UpdatePateint.Visibility = Visibility.Visible;
        }

        private void ProfileClicked(object sender, RoutedEventArgs e)
        {
            NurseFrame.Navigate(new Profile());
            UpdatePateint.Visibility = Visibility.Collapsed;
        }

        private void LogOutClicked(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Window win = Window.GetWindow(this);
            win.Close();
        }

        private void Reg_User(object sender, RoutedEventArgs e)
        {
            string Name = NameInput.Text;
            string FatherName = FatherNameInput.Text;
            int Age = int.Parse(AgeInput.Text);
            string Sex = rMale.IsChecked == true ? "Male" : rFemale.IsChecked == true ? "Female" : null;
            string Disease = DiseaseInput.Text;
            string FIN = FINInput.Text;

            Patient newPatient = new Patient(Name, FatherName, Age, Sex, Disease, FIN);
            int DoctorID = 1;

            SendToDb db = new SendToDb();
            string result = db.InsertPatient(newPatient, DoctorID);

            if (result == "Successful")
            {
                MessageBox.Show("Patient registered successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Failed to register patient. Error: {result}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
