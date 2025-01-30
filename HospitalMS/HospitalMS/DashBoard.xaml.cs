using HospitalMS.Control;
using HospitalMS.Model;
using HospitalMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
      public static int ID;
        public static DashBoard instance;
        public DashBoard()
        {
            InitializeComponent();
            instance = this;
            LoadData();
        }

        public void LoadData()
        {
            List<object> Info = new List<object>();
            Info.Clear();
            Info =  UserManager.ChangeMainFrame(UserManager.role);
            UserData.ItemsSource = Info;
        }

        private void OnGridChange(object sender, SelectionChangedEventArgs e)
        {

            // First, reset the background color for all rows
            foreach (var item in UserData.Items)
            {
                DataGridRow row = (DataGridRow)UserData.ItemContainerGenerator.ContainerFromItem(item);
                if (row != null)
                {
                    row.Background = new SolidColorBrush(Colors.White); // Reset to default
                }
            }

            // Apply new selection styling
            if (UserData.SelectedItem is Patient selected)
            {
                ID = selected.PId;
                DocPage doc = new DocPage();
                doc.PID.Content = selected.PId;

                DataGridRow selectedRow = (DataGridRow)UserData.ItemContainerGenerator.ContainerFromItem(selected);
                if (selectedRow != null)
                {
                    selectedRow.Background = new SolidColorBrush(Colors.LightBlue); // Highlight selected row
                }
            }
        }
    }
}
