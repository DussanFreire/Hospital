using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class ConcretePatientFactory : PatientFactory
    {
        public override IPatient GetPatient(string Patient)
        {
            switch (Patient)
            {
                case "Insured":
                    return new InsuredPatient();
                case "External":
                    return new ExteranlPatient();
                default:
                    throw new Exception(string.Format("Patient '{0}' cannot be created", Patient));
            }
        }
    }
}
