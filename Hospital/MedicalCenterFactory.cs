using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public abstract class MedicalCenterFactory
    {
        public abstract IMedicalCenter GetMedicalCenter(string MedicalCenter);
    }
}
