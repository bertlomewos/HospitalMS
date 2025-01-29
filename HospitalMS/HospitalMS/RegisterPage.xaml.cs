using HospitalMS.Model;
using HospitalMS.Control;
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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        UserManager userControl = new UserManager();
        public RegisterPage()
        {
            InitializeComponent();
            RoleInput.SelectionChanged += show_extra;

        }
        void show_extra(object sender, SelectionChangedEventArgs e)
        {
            string Role = (RoleInput.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (Role == "Doctor")
            {
                DocLabels.Visibility = Visibility.Visible;
            }
            else
            {
                DocLabels.Visibility = Visibility.Collapsed;
            }
        }
        private void Reg_User(object sender, RoutedEventArgs e)
        {
            try
            {
                // Retrieve common input values
                string fname = FirstNameInput.Text;
                string lname = LastNameInput.Text;
                string pass = PasswordInput.Password;
                string role = (RoleInput.SelectedItem as ComboBoxItem)?.Content.ToString();
                int age = int.Parse(AgeInput.Text);
                string gender = rMale.IsChecked == true ? "Male" : rFemale.IsChecked == true ? "Female" : null;
                string specialization = Specialization.Text;
                string fin = FINInput.Text;

                // Call the helper function to create and validate the user
                User newUser = CreateUser(fname, lname, pass, role, age, gender, fin, specialization);
                if (newUser != null)
                {
                    string resultMessage = userControl.checkForUserinfo(newUser);
                    MessageBox.Show(resultMessage);
                }
                else
                {
                    MessageBox.Show("Invalid role selected.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private User CreateUser(string fname, string lname, string pass, string role, int age, string gender, string fin, string specialization)
        {
            // Factory-style logic for creating users based on role
            return role switch
            {
                "Doctor" => new Doc(fname, lname, pass, role, age, gender, fin, specialization),
                "Admin" => new Admin(fname, lname, pass, role, age, gender, fin),
                "Nurse" => new Nurse(fname, lname, pass, role, age, gender, fin),
                "Finance" => new finance(fname, lname, pass, role, age, gender, fin),
                "OPS" => new Admin(fname, lname, pass, role, age, gender, fin),
                _ => null // Return null for invalid roles
            };
        }

    }
}
