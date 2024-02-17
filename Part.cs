using System;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SoapHelper
{
    [Serializable]
    public class Part
    {
        public CustomHeader customHeader { get; set; }

        [SoapAttribute(DataType = "Designation")]
        public string Designation { get; set; }

        [SoapAttribute(DataType = "Name")]
        public string Name { get; set; }

        [SoapAttribute(DataType = "Weight")]
        public double Weight { get; set; }
    }
}
