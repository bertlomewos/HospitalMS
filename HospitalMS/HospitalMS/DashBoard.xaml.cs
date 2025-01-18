﻿using HospitalMS.Model;
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
    /// Interaction logic for DashBoard.xaml
    /// </summary>
    public partial class DashBoard : Page
    {
        private GetFromDb _getFromDb;

        public DashBoard(String role)
        {
            InitializeComponent();
            _getFromDb = new GetFromDb();
            LoadData(role);
        }

        public void LoadData(string role)
        {
            if (role == "Admin")
            {
                List<User> users = _getFromDb.GetUser();
                UserData.ItemsSource = users;
            }
            else if (role == "Doctor" || role == "Nurse")
            {
                List<Patient> patients = _getFromDb.GetPatient();
                UserData.ItemsSource = patients;
            }
        }
    }
}
