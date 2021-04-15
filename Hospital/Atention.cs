using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Atention : IAtention
    {
        public long Id { get ; set ; }
        public string Date { get ; set ; }
        public IPatient Patient { get ; set ; }

        public double CalculteCost()
        {
            throw new NotImplementedException();
        }
    }
}
