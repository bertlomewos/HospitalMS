using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS.Model
{
    internal class Patient 
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Disease { get; set; }
        public string FIN { get; set; }
        public int DoctorID { get; set; }

        public Patient(string Name, string FatherName, int Age, 
            string Sex, string Disease, string FIN) //to send to the Database
        {
            this.Name = Name;
            this.FatherName = FatherName;
            this.Age = Age;
            this.Sex = Sex;
            this.Disease = Disease;
            this.FIN = FIN;
        }

        public Patient(int PId, string Name, string FatherName, int Age,
            string Sex, string Disease, string FIN, int DoctorID) //to get from the Database
        {
            this.PId = PId;
            this.Name = Name;
            this.FatherName = FatherName;
            this.Age = Age;
            this.Sex = Sex;
            this.Disease = Disease;
            this.FIN = FIN;
            this.DoctorID = DoctorID;
        }

    }
}
