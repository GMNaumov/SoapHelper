using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace SoapHelper
{
    /// <summary>
    /// А вот тут уже попробуем повозиться с чистым SOAP
    /// Serialization.Formatters.Soap сама не подключится, нужно подключать "ручками"
    /// </summary>
    public class SoapSerializer
    {
        private readonly string fileName;

        /// <summary>
        /// Волшебный тип, который должен "всё сделать сам" - т.е. сериализовать данные в нужном формате
        /// </summary>
        private SoapFormatter formatter;

        public SoapSerializer(string fileName)
        {
            this.fileName = fileName;
        }
        

        /// <summary>
        /// Из хороших новостей - получилось сериализовать в Envelope (как это правильно называть-то?...) без особых проблем.
        /// Из плохих новостей - получилось так себе. Какая-то шляпа с именами свойств. По всей видимости, 
        /// </summary>
        public void SoapSerialize()
        {
            SoapFormatter soapFormatter = new SoapFormatter();

            CustomHeader header = new CustomHeader { name = "UserName", password = "VeryStrongPassword" };
            Part p = new Part { customHeader = header, Designation = "1.000.000.000", Name = "Cover", Weight = 12.5 };

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, p);

                Console.WriteLine("Parts have been serialized!");
            }
        }
    }
}
