using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class finance : User
    {
        public int FinanceID {  get; set; }


        public finance(string Fname, string Lname, string password, string role,
            int age, string sex, string Fin) : base(Fname, Lname, password, role,
         age, sex, Fin) //to send to the Database
        {
        }
        public finance(int Id, string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, int FinanceID) : base(Id, Fname, Lname, password, role,
         age, sex, Fin) //to get from the Database
        {
            this.FinanceID = FinanceID;
        }
    }

}
