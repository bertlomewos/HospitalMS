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
        Update update = new Update();
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
                List<User> users = get.GetUser();
                foreach (User user in users)
                {
                    if (user.Id.ToString() == UID && user.Password == Pass)
                    {
                        MainWindow main = new MainWindow();
                        Profile.userID = user.Id;
                        main.ChangeMainFrame(user.Role);
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
    }
}
