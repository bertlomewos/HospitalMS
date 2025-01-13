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
using System.Windows.Shapes;

namespace HospitalMS
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        GetFromDb getFromDb = new GetFromDb();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, RoutedEventArgs e)
        {
            ValiditateUser();
        }

        public void ValiditateUser()
        {

            string UID = UserID.Text;
            string Pass = PasswordBox.Password;
            try
            {
                if (string.IsNullOrEmpty(Pass))
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }
                if (string.IsNullOrEmpty(UID))
                {
                    MessageBox.Show("Please Enter User ID");
                    return;
                }
                List<User> users = getFromDb.GetUser();

                foreach (User user in users)
                {
                    if (user.Id.ToString() == UID && user.Password == Pass)
                    {
                        MainWindow main = new MainWindow();
                        main.ChangeMainFrame(user.Role);
                        return;
                    }
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
