using Azure;
using HospitalMS.Model;
using HospitalMS.Repository;
using Mysqlx.Connection;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GetFromDb getFromDb = new GetFromDb();
        public static List<object> DataList = new List<object>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void ChangeMainFrame(string role)
        {
            switch (role)
            {
                case "Admin":
                    ToDisplay(new AdminPage(), GetFromDb.GetUser());
                    break;
                case "Doctor":
                    ToDisplay(new DocPage(), Doc.GetThePaitent());
                    break;
                case "Nurse":
                    ToDisplay(new NursePage(), Doc.GetThePaitent());
                    break;
                case "Finance":
                    ToDisplay(new FinancePage(), finance.GetTheExpense());
                    break;
                case "Ops":
                    //ToDisplay(new OpsPage(), Ops.GetRecords());
                    break;
                default:
                    MessageBox.Show("Invalid role specified.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }


        public void ToDisplay<T>(Page page, List<T> dataList)
        {
            try
            {
                this.Show();
                MainFrame.Navigate(page);
                DataList.Clear();
                DataList.AddRange(dataList.Cast<object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
