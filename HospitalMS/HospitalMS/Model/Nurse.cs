using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class Nurse : User
    {
        public enum NurseRole
        {
            General,
            Specialist,
            HeadNurse
        }
        public int NId { get; set; }
        public NurseRole NRole { get; set; }
        public int AssignedDoctorID { get; set; }


        public Nurse(string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, NurseRole NRole) : base(Fname, Lname, password, role,
                 age, sex, Fin)//to send to the Database
        {
            this.NRole = NRole;
        }

        public Nurse(int Id, string Fname, string Lname, string password, string role,
            int age, string sex, string Fin, int NId, NurseRole NRole, int AssignedDoctorID) : base(Id, Fname, Lname, password, role,
                 age, sex, Fin)//to get from the Database
        {
            this.NRole = NRole;
            this.AssignedDoctorID = AssignedDoctorID;
            this.NId = NId;
        }

    } 

}
