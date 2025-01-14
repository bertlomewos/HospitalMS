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
using static HospitalMS.Model.Nurse;

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
            else if (Role == "Nurse")
            {
                DocLabels.Visibility = Visibility.Collapsed;
            }
            else
            {
                DocLabels.Visibility = Visibility.Collapsed;
            }
        }
        private void Reg_User(object sender, RoutedEventArgs e)
        {

            string Fname = FirstNameInput.Text;
            string Lname = LastNameInput.Text;
            string Pass = PasswordInput.Password;
            string Role = (RoleInput.SelectedItem as ComboBoxItem)?.Content.ToString();
            int Age = int.Parse(AgeInput.Text); ;
            string Gender = rMale.IsChecked == true ? "Male" : rFemale.IsChecked == true ? "Female" : null;
            string FIN = FINInput.Text;
            User newUser;
            if (Role == "Doctor")
            {
                
                string specialization = (Specialization.SelectedItem as ComboBoxItem)?.Content.ToString();
                newUser = new Doc(Fname, Lname, Pass, Role, Age, Gender, FIN, specialization);
                MessageBox.Show(userControl.checkForUserinfo(newUser));
            }
            else if (Role == "Admin")
            {
                newUser = new Admin(Fname, Lname, Pass, Role, Age, Gender, FIN);
                MessageBox.Show(userControl.checkForUserinfo(newUser));
            }
            else if (Role == "Nurse")
            {                               
                newUser = new Nurse(Fname, Lname, Pass, Role, Age, Gender, FIN);
                MessageBox.Show(userControl.checkForUserinfo(newUser));

            }

        }

 
    }
}
