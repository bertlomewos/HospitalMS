using HospitalMS.Model;
using HospitalMS.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HospitalMS.Control
{
    internal class UserManager
    {
        SendToDb sd = new SendToDb();
        GetFromDb get = new GetFromDb();
        UpdateTheDab update = new UpdateTheDab();
        GetFromDb getFromDb = new GetFromDb();
        public static string role;
        public string checkForUserinfo(User user)
        {
            string result = "";
            if (user == null)
            {
                return "User can not be null";
            }

            if(user.FName.Length > 20 && user.LName.Length > 20)
            {
                return "User can not be null";
                
            }
            if(user is Doc UsDoc)
            {
                result = sd.InsertDoc(UsDoc);
            }
            if (user is Admin usrAdmin)
            {
                 result = sd.InsertUser(usrAdmin);
            }
            if (user is finance finuser)
            { 
                result = sd.Insertfin(finuser);
            }
            
            if (string.IsNullOrEmpty(user.FName) || string.IsNullOrEmpty(user.LName) || string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.Role) || string.IsNullOrEmpty(user.FIN))
            {  
                return "Please fill in all required fields.";
            }
          return  result;

        }

        public string UpdateUser(User user)
        {
            string result = "";
            if (user == null)
            {
                return "User can not be null";
            }

            if (user.FName.Length > 20 && user.LName.Length > 20)
            {
                return "User can not be null";

            }

            if (string.IsNullOrEmpty(user.FName) || string.IsNullOrEmpty(user.LName) || string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrEmpty(user.Role) || string.IsNullOrEmpty(user.FIN))
            {
                return "Please fill in all required fields.";
            }

            result = update.UpdateUser(user);
            return result;
           
        }

        public string ValiditateUser(string UID, string Pass)
        {
            try
            {
                if (string.IsNullOrEmpty(Pass))
                {
                    return "Password";
                }
                if (string.IsNullOrEmpty(UID))
                {
                    return "UserID";
                }
                List<User> users = GetFromDb.GetUser();
                foreach (User user in users)
                {
                    if (user.Id.ToString() == UID && user.Password == Pass)
                    {
                        MainWindow main = new MainWindow();
                        Profile.userID = user.Id;
                        UserManager userManager = new UserManager();
                        switch (user.Role)
                        {
                            case "Admin":
                                userManager.ToDisplay<AdminPage>(new AdminPage());
                                break;
                            case "Doctor":
                                userManager.ToDisplay<DocPage>(new DocPage());
                                break;
                            case "Nurse":
                                userManager.ToDisplay<NursePage>(new NursePage());
                                break;
                            case "Finance":
                                userManager.ToDisplay<FinancePage>(new FinancePage());
                                break;
                            default:
                                MessageBox.Show("Invalid role specified.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                break;
                        }
                        role = user.Role;
                        return "Successful";
                    }
                  
                }

            }
            catch (Exception ex)
            {
                return  ex.Message;
            }
            
            return "Failed";

        }

        public static List<object> ChangeMainFrame(string role)
        {
            List<object> DataList = new List<object>();
            DataList.Clear();

            switch (role)
            {
                case "Admin":
                    DataList.AddRange(GetFromDb.GetUser());
                    return DataList;
                case "Doctor":
                    DataList.AddRange(Doc.GetThePaitent());
                    return DataList;
                case "Nurse":
                    DataList.AddRange(Nurse.GetThePaitent());
                    return DataList;
                case "Finance":
                    DataList.AddRange(finance.GetTheExpense());
                    return DataList;
                default:
                    return null;
                  
            }

        }


        public  void ToDisplay<T>(Page page)
        {
            try
            {
                MainWindow mn = new MainWindow();
                mn.Show();
                mn.MainFrame.Navigate(page);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return;
        }
    }
}
