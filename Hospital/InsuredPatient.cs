using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class InsuredPatient : IInsuredPatient
    {
        public double DiscountRate { get ; set ; }
        public long Id { get ; set ; }
        public string Name { get ; set ; }
        public string Type { get ; set; }
        public string PlaceOfRegistration { get ; set; }
        public InsuredPatient()
        {
            Type = "Insured";
            DiscountRate = 0.5;
        }

        public void DisplayPatientInformation()
        {
            Console.WriteLine($"------------------ {Type.ToUpper()} PATIENT ------------------");
            Console.WriteLine($"Place of registration: {PlaceOfRegistration}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Discount Rate: {DiscountRate*100} %");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
