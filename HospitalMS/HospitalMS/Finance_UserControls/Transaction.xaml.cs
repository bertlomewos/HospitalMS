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
    /// Interaction logic for Transaction.xaml
    /// </summary>
    public partial class Transaction : UserControl
    {

        MainDbFunction db = new MainDbFunction();
        public Transaction()
        {
            InitializeComponent();
        }

        public void trans_Load(object sender, RoutedEventArgs e)
        {

            try
            {
                string query = "\tSelect transaction_Type,transaction_Date,transaction_Amount  from financetb"; // Declare query
                DataSet ds = db.getData(query);          // Call the database function
                maingrid.ItemsSource = ds.Tables[0].DefaultView; // Set data to the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }

    }
}
