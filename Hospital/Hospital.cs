using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Hospital : IMedicalCenter
    {
        public string MedicalCenterName { get ; set ; }
        public string City { get ; set ; }

        public void RegisterPatientOnTheSystem(IPatient patient)
        {
            patient.PlaceOfRegistration = MedicalCenterName;
            PatientList.Instance.AddNewPatient(patient);
        }

        public void DisplayPatientsOnTheSystem()
        {
            PatientList.Instance.DisplayPatients();
        }
    }
}
