using System;
using System.Web.Services.Protocols;

namespace SoapHelper
{
    [Serializable]
    public class CustomHeader : SoapHeader
    {
        public string name { get; set; }

        public string password { get; set; }
    }
}
