using HospitalMS.Model;
using HospitalMS.Control;
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
using System.Windows.Shapes;

namespace HospitalMS
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, RoutedEventArgs e)
        {
            string UID = UserID.Text;
            string Pass = PasswordBox.Password;
            UserManager user  = new UserManager();
            user.ValiditateUser(UID, Pass);
            this.Close();
        }

       
    }
}
