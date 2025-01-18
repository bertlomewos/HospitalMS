﻿using HospitalMS.Model;
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
    /// Interaction logic for DocPage.xaml
    /// </summary>
    public partial class DocPage : Page
    {
        public DocPage(String role)
        {
            InitializeComponent();
        }

        private void DashboardClicked(object sender, RoutedEventArgs e)
        {
           DocFrame.Navigate(new DashBoard("Doctor"));
        }

        private void ProfileClicked(object sender, RoutedEventArgs e)
        {
            DocFrame.Navigate(new Profile());
        }

        private void LogOutClicked(object sender, RoutedEventArgs e)
        {

            LoginWindow login = new LoginWindow();
            login.Show();
            Window win = Window.GetWindow(this);
            win.Close();

        }
    }
}
