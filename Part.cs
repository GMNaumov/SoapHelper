using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapHelper
{
    [Serializable]
    internal class Part
    {
        public string Designation { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
