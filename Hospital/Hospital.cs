using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Hospital
    {
        public List<IAtention> Atentions { get; set; }
        public PatientList Patients { get; set; }
        public void AddNewInsuredPatient();
    }
}
