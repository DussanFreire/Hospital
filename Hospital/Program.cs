using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factories:
            ConcretePatientFactory patientFactory = new ConcretePatientFactory();
            ConcreteMedicalCenterFactory medicalCenterFactory = new ConcreteMedicalCenterFactory();

            // Medical center declarations:
            IMedicalCenter losOlivosCba = medicalCenterFactory.GetMedicalCenter("Hospital");
            losOlivosCba.MedicalCenterName = "Hospital Los Olivos Cochabamba";


            IMedicalCenter losOlivosScz = medicalCenterFactory.GetMedicalCenter("Hospital");
            losOlivosScz.MedicalCenterName = "Hospital Los Olivos Santa Cruz";


            // Insured and external patient declarations:
            IPatient sergio = patientFactory.GetPatient("Insured");
            sergio.Id = 4545545;
            sergio.Name = "Sergio Ortiz";


            IPatient camila = patientFactory.GetPatient("External");
            camila.Id = 789952;
            camila.Name = "Camila Camacho";


            // Registration on the medical centers:

            losOlivosCba.RegisterPatientOnTheSystem(sergio);


            losOlivosScz.RegisterPatientOnTheSystem(camila);


            // Display singleton

            losOlivosCba.DisplayPatientsOnTheSystem();


        }
    }
}
