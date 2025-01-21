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
    internal class PatientManager
    {
        SendToDb sd = new SendToDb();
        GetFromDb get = new GetFromDb();

        public string CheckForPatientInfo(Patient patient, int doctorID)
        {
            if (patient == null)
            {
                return "Patient cannot be null.";
            }

            if (string.IsNullOrEmpty(patient.Name) || patient.Age <= 0 ||
                string.IsNullOrEmpty(patient.Sex) || string.IsNullOrEmpty(patient.Disease) ||
                string.IsNullOrEmpty(patient.FIN))
            {
                return "Please fill in all required fields.";
            }

            string result = sd.InsertPatient(patient, doctorID);

            return result.StartsWith("Error") ? result : $"Patient {patient.Name} has been registered successfully.";
        }

        // Method to get a list of all patients
        public List<Patient> GetPatient()
        {
            try
            {
                return GetFromDb.GetPatient(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<Patient>();
            }
        }
    }
}
