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
using HospitalMS.Finance_UserControls;

namespace HospitalMS
{
    /// <summary>
    /// Interaction logic for Finance.xaml
    /// </summary>
    public partial class Finance : Window
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void budget_Click(object sender, RoutedEventArgs e)
        {

            MainContent.Children.Clear();

            MainContent.Children.Add(new Budget());

            //budget_UC b = new budget_UC();

        }

        private void Transaction_click(object sender, RoutedEventArgs e)
        {

            MainContent.Children.Clear();
            MainContent.Children.Add(new Transaction());

        }
    }
}

