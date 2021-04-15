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

    }
}
