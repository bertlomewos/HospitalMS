using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class User
    {
        public static int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string FIN { get; set; } 

        public User(string Fname, string Lname, string password,  string role, 
            int age, string sex, string Fin)
        {
            this.FName = Fname;
            this.LName = Lname;
            this.Password = password;
            this.Role = role;
            this.Age = age;
            this.Sex = sex;
            this.FIN = Fin;                                                                                                     
        }
    }
}
