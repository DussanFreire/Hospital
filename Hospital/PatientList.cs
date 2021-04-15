using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    
    public class PatientList
    {
        private static List<IPatient> _instance = new List<IPatient>();
        private PatientList() { }

        public static List<IPatient> Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
