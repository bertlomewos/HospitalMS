using HospitalMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class Nurse : User
    {
        public int NId { get; set; }
        public int AssignedDoctorID { get; set; }


        public Nurse(string Fname, string Lname, string password, string role,
            int age, string sex, string Fin) : base(Fname, Lname, password, role,
                 age, sex, Fin)//to send to the Database
        {
        }

        public Nurse(int Id, string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, int NId, int AssignedDoctorID) : base(Id, Fname, Lname, password, role,
                 age, sex, Fin)//to get from the Database
        {
            this.AssignedDoctorID = AssignedDoctorID;
            this.NId = NId;
        }

        public static List<Patient> GetThePaitent()
        {
            return GetFromDb.GetPatient();
        } 

    } 

}
