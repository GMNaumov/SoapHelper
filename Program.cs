namespace SoapHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryInfoApi countryInfoApi = new CountryInfoApi();
            countryInfoApi.GetFullCountryInfo("RU");

            SoapSerializer soapSerializer = new SoapSerializer("parts.xml");
            soapSerializer.SoapSerialize();
        }
    }
}
