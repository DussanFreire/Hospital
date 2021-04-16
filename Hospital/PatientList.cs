using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    
    public class PatientList
    {
        private static PatientList _instance = new PatientList();
        private static List<IPatient> _patients = new List<IPatient>();

        private PatientList() { }

        public static PatientList Instance
        {
            get
            {
                return _instance;
            }
        }
        public void AddNewPatient(IPatient patient) {
            _patients.Add(patient);
        }

        public void DisplayPatients()
        {
            Console.WriteLine("-------------------- PATIENT LIST --------------------");
            foreach(IPatient p in _patients)
            {
                p.DisplayPatientInformation();
            }
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
