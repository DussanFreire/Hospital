using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public abstract class PatientFactory
    {
        public abstract IPatient GetPatient(string patient);
    }
}
