using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class ExteranlPatient : IExternalPatient
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
