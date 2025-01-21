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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void RegisterClicked(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new RegisterPage());
        }

        private void DashboardClicked(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new DashBoard());
        }

        private void ProfileClicked(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new Profile());
        }

        private void LogOutClicked(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            Window win = Window.GetWindow(this);
            win.Close();

        }
        public void LoadData(List<Object> Users)
        {
        }
    }
}
