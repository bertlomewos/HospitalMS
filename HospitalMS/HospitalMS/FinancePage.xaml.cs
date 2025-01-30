using HospitalMS.Model;
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
    /// Interaction logic for FinancePage.xaml
    /// </summary>
    public partial class FinancePage : Page
    {
        public FinancePage()
        {
            InitializeComponent();
        }

        private void DashboardClicked(object sender, RoutedEventArgs e)
        {
            FinFrame.Navigate(new DashBoard());
            Diagnos.Visibility = Visibility.Visible;
        }

        private void ProfileClicked(object sender, RoutedEventArgs e)
        {
            FinFrame.Navigate(new Profile());
            Diagnos.Visibility = Visibility.Collapsed;
        }

        private void LogOutClicked(object sender, RoutedEventArgs e)
        {
            Diagnos.Visibility = Visibility.Collapsed;
            LoginWindow login = new LoginWindow();
            login.Show();
            Window win = Window.GetWindow(this);
            win.Close();
        }

        private void CalculateMoney(object sender, RoutedEventArgs e)
        {
            int Dailyexpense = int.Parse(LoseTextBox.Text);
            int Dailygain = int.Parse(GainTextBox.Text);
            int Dailyprofit = Dailygain - Dailyexpense;

            DashBoard.instance.LoadData();
            Expenses ex = new Expenses(Dailyexpense, Dailygain, Dailyprofit);
            finance.ExpenseRge(ex);

        }
    }
}
