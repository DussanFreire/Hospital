using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public interface IInsuredPatient: IPatient
    {
        public double DiscountRate { get; set; }
    }
}
