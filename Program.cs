namespace SoapHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part partOne = new Part() { Designation = "111.222", Name = "Вал", Weight = 1.5 };
            Part partTwo = new Part() { Designation = "333.444", Name = "Корпус", Weight = 6.0 };
            Part partThree = new Part() { Designation = "555.666", Name = "Колесо", Weight = 4.3 };

            Part[] parts = new Part[] { partOne, partTwo, partThree };

            SoapSerializer soapSerializer = new SoapSerializer("parts.xml");
            soapSerializer.SoapSerialize(parts);
        }
    }
}
