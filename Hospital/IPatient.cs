using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public interface IPatient
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
