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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        GetFromDb getFromDb = new GetFromDb();
        UserManager userControl = new UserManager();
        public static int userID;
        public Profile()
        {
            InitializeComponent();
            LoadProfile();
        }
        public void LoadProfile()
        {
            List<User> users = GetFromDb.GetUser();
            foreach (User user in users)
            {
                if (user.Id == userID)
                {
                    List<User> Me = new List<User>();
                    Me.Add(user);
                    UserprofData.ItemsSource = Me;
                }
            }
        }

        private void Update_btn(object sender, RoutedEventArgs e)
        {
            if (UserprofData.SelectedItem is User User)
            {
                User.FName = FirstNameInput.Text;
                User.LName = LastNameInput.Text;
                User.Password = PasswordInput.Text;
                User.Age = int.Parse(AgeInput.Text);
                MessageBox.Show(userControl.UpdateUser(User));
                LoadProfile();
            }

        }

        private void OnGridChange(object sender, SelectionChangedEventArgs e)
        {
            if(UserprofData.SelectedItem is User Selected)
            {
                FirstNameInput.Text = Selected.FName;
                LastNameInput.Text = Selected.LName;
                PasswordInput.Text = Selected.Password;
                AgeInput.Text = Selected.Age.ToString();
   
            }
        }
    }
}
