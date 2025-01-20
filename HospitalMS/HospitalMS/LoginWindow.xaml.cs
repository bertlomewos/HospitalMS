﻿using HospitalMS.Model;
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
            LoginStatus();
        }
        private void LoginStatus()
        {
            string UID = UserID.Text;
            string Pass = PasswordBox.Password;
            UserManager user = new UserManager();
            string result = user.ValiditateUser(UID, Pass);
            if (result == "Failed")
            {
                MessageBox.Show("Failed to enter please check your");

            }
            else if (result == "Password")
            {
                MessageBox.Show("Please enter password");
            }
            else if (result == "UserID")
            {
                MessageBox.Show("Please enter Use ID");
            }
            else if (result == "Successful")
            {
                this.Close();
            }
        }

       
    }
}
