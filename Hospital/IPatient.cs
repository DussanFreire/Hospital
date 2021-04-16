using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public interface IPatient
    {
        public string Type { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }

        public string PlaceOfRegistration { get; set; }
        public void DisplayPatientInformation();
    }
}
