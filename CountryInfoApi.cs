using System;
using SoapHelper.CountryInfoService;

namespace SoapHelper
{
    /// <summary>
    /// Пример взаимодействия через SOAP с забавным сервисом, предоставляющим информацию о странах мира
    /// Ссылка (есть в App.config, но мало ли): http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso
    /// </summary>
    class CountryInfoApi
    {
        /// <summary>
        /// Во кто бы мне сказал - почему именно через этот тип получается вызывать методы удалённо?
        /// Чистый тык пальцем в небо, плюс благославление великого бога Рандома - и всё получилось
        /// </summary>
        CountryInfoServiceSoapTypeClient _serviceSoapTypeClient;

        public CountryInfoApi()
        {
            _serviceSoapTypeClient = new CountryInfoServiceSoapTypeClient();
        }

        /// <summary>
        /// Ну вот, с божьей помощью что-то получилось.
        /// Никаких вам богомерзких SOAP-запросов с Envelopе-ами, чистый вызов удалённой процедуры.
        /// То ли это C# всё позволяет, то ли кому-то нужно курить теорию
        /// </summary>
        /// <param name="countryCode"></param>
        public void GetFullCountryInfo(string countryCode)
        {
            tCountryInfo countryInfo = _serviceSoapTypeClient.FullCountryInfo(countryCode);

            if (countryInfo != null ) 
            {
                Console.WriteLine($"We've found country by code: {countryInfo.sName}");
                Console.WriteLine($"The capital of {countryInfo.sName} is {countryInfo.sCapitalCity}");
                Console.WriteLine($"The currency code if {countryInfo.sName} is {countryInfo.sCurrencyISOCode}");
                Console.ReadLine();
            }

            
        }
    }
}
