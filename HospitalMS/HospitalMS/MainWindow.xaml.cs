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
        internal static List<User> TheHolder;
        public MainWindow()
        {
            InitializeComponent(); 
        }

        public void ChangeMainFrame(string role)
        {
            TheHolder = new List<User>();
            if (role == "Admin")
            {
                this.Show();
                MainFrame.Navigate(new AdminPage(role));
                TheHolder = getFromDb.GetUser();
            }
            else if (role == "Doctor" || role == "Nurse")
            {
                // Get only patients for Doctor/Nurse
                this.Show();
                MainFrame.Navigate(role == "Doctor" ? new DocPage(role) : new NursePage(role));
                TheHolder = getFromDb.GetUser().Where(u => u.Role == "Patient").ToList(); 
            }

        }

    }
}
