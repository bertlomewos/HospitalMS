using HospitalMS.Model;
using HospitalMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HospitalMS.Control
{
    internal class UserControle
    {
        SendToDb sd = new SendToDb();
        public string checkForUserinfo(User user)
        {
            if(user == null)
            {
                
                return "User can not be null";
               
            }

            if(user.FName.Length > 20 && user.LName.Length > 20)
            {
                return "User can not be null";
            }

            string result = sd.InsertUser(user);
         return "User " + result + " has been registered";
        }
    }
}
