using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace SoapHelper
{
    internal class SoapSerializer
    {
        private readonly string fileName;

        public SoapSerializer(string fileName)
        {
            this.fileName = fileName;
        }

        public void SoapSerialize(Part[] parts)
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, parts);

                Console.WriteLine("Parts have been serialized!");
            }
        }
    }
}
