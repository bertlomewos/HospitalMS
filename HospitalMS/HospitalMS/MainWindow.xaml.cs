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
        internal static List<User> TheHolder;
        internal static List<Patient> PatientsHolder;

        public MainWindow()
        {
            InitializeComponent(); 
        }

        public void ChangeMainFrame(string role)
        {
            if (role == "Admin")
            {
                MainFrame.Navigate(new AdminPage());
                TheHolder = new List<User>();
            }
            else if (role == "Doctor")
            {
                PatientsHolder = new List<Patient>();
                MainFrame.Navigate(new DocPage());
            }
            else if(role == "Nurse")
            {
                PatientsHolder = new List<Patient>();
                MainFrame.Navigate(new NursePage());
            }


        }

    }
}
