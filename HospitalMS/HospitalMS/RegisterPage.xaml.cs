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
        UserControle userControl = new UserControle();
        public RegisterPage()
        {
            InitializeComponent();
         
        }

        private void Reg_User(object sender, RoutedEventArgs e)
        {
            RegisterUSer();

        }

        public void RegisterUSer()
        {
            string Fname = FirstNameInput.Text;
            string Lname = LastNameInput.Text;
            string Pass = PasswordInput.Password;
            string Role = (RoleInput.SelectedItem as ComboBoxItem)?.Content.ToString();
            int Age = 0;
            if (!int.TryParse(AgeInput.Text, out Age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            string Gender = rMale.IsChecked == true ? "Male" : rFemale.IsChecked == true ? "Female" : null;
            if (string.IsNullOrEmpty(Gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
            string FIN = FINInput.Text;


            if (string.IsNullOrEmpty(Fname) || string.IsNullOrEmpty(Lname) || string.IsNullOrEmpty(Pass) ||
                string.IsNullOrEmpty(Role) || string.IsNullOrEmpty(FIN))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            User newUser = new User(Fname, Lname, Pass, Role, Age, Gender, FIN);
            MessageBox.Show(userControl.checkForUserinfo(newUser));
        }
    }
}
