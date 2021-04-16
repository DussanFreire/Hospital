using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class ConcreteMedicalCenterFactory : MedicalCenterFactory
    {
        public override IMedicalCenter GetMedicalCenter(string MedicalCenter)
        {
            switch (MedicalCenter)
            {
                case "Hospital":
                    return new Hospital();
                default:
                    throw new Exception(string.Format("MedicalCenter '{0}' cannot be created", MedicalCenter));
            }
        }
    }
}
