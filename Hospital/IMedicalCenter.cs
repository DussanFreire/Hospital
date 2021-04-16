using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public interface IMedicalCenter
    {
        public string MedicalCenterName { get; set; }
        public string City { get; set; }
        public void RegisterPatientOnTheSystem(IPatient patient);
        public void DisplayPatientsOnTheSystem();
    }
}
