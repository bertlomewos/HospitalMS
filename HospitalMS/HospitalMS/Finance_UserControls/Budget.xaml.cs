using System;
using System.Collections.Generic;
using System.Data;
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

namespace HospitalMS.Finance_UserControls
{
    /// <summary>
    /// Interaction logic for budget.xaml
    /// </summary>
    public partial class Budget : UserControl
    {

        MainDbFunction db = new MainDbFunction();

        public Budget()
        {
            InitializeComponent();
        }


        public void Budget_load(object sender, RoutedEventArgs e)
        {

            try
            {
                string query = "Select Revenue,Expenses, Budget from financetb"; // Declare query
                DataSet ds = db.getData(query);          // Call the database function
                BudgetGrid.ItemsSource = ds.Tables[0].DefaultView; // Set data to the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }
    }
}
