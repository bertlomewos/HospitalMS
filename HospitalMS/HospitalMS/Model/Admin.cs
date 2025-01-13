using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class Admin : User
    {
        public Admin(string Fname, string Lname, string password, string role,
        int age, string sex, string Fin): base(Fname, Lname, password, role, age, sex, Fin) 
        {
        
        }
        public Admin(int Id,string Fname, string Lname, string password, string role,
        int age, string sex, string Fin) : base(Id, Fname, Lname, password, role, age, sex, Fin)
        {

        }
    }
}
