using Mysqlx.Crud;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class Doc : User
    {
        public int DId { get; set; }
        public string Specialization { get; set; }

       

        public Doc(string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, string Specialization) : base(Fname, Lname, password, role,
         age, sex, Fin) //to send to the Database
        {
            this.Specialization = Specialization;
        }
        public Doc(int Id, string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, int Did, string Specialization) : base(Id, Fname, Lname, password, role,
         age, sex, Fin) //to get from the Database
        {
            this.Specialization = Specialization;
            this.DId = Did;
        }


    }
}
