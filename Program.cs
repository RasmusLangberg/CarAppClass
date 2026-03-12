using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar1 = new Car("Toyota", "Corolla", 2020, 'A', "Benzin", 22.5);
            Car myCar2 = new Car("Nissan", "Qashqai", 2017, 'M', "Diesel", 17.8);

            // Tænd motor og kør
            myCar1.IsEngineOn = true;
            myCar1.Drive(120);
            myCar1.Drive(45);

            // Motor er slukket – Drive() gør ingenting
            myCar2.Drive(50); // odometer forbliver 0

            // Udskriv detaljer
            Console.WriteLine(myCar1.GetCarDetails());
            Console.WriteLine(myCar2.GetCarDetails());

            // Beregn turpris
            double price = myCar1.CalculateTripPrice(200, 15.50);
            Console.WriteLine($"Turpris: {price:F2} kr");

            // Test properties direkte
            Console.WriteLine($"Brændstof: {myCar1.FuelType}");
            Console.WriteLine($"Odometer: {myCar1.Odometer} km");















        }
    }
}
