using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public interface IAtention
    {
        public long Id { get; set; }
        public string Date { get; set; }
        public IPatient Patient { get; set; }
        public double CalculteCost();
    }
}
