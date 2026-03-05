using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Indtast mærke: ");
            string brand = Console.ReadLine();

            Console.Write("Indtast model: ");
            string model = Console.ReadLine();

            Console.Write("Indtast år: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Indtast geartype (f/m): ");
            char gearType = char.Parse(Console.ReadLine());

            Console.Write("Indtast km-stand: ");
            int odometer = int.Parse(Console.ReadLine());

            Console.Write("Indtast brændstoftype (Benzin/Diesel/Electric/Hybrid): ");
            Fueltype.FuelType fuelType = Enum.Parse<Fueltype.FuelType>(Console.ReadLine());

            Console.Write("Er motoren tændt (true/false): ");
            bool isEngineOn = bool.Parse(Console.ReadLine());

            Console.Write("Indtast km/l: ");
            double kmPerLiter = double.Parse(Console.ReadLine());

            Console.Write("Indtast prisen på det brændstof din bil bruger");
            double LiterPrice = double.Parse(Console.ReadLine());


            Car userCar = new Car(brand, model, year, gearType, odometer, isEngineOn, fuelType, kmPerLiter, LiterPrice);

            

            userCar.CarDetails();
        



            Trip mytrip = new Trip (userCar, 200,new DateTime(2026,5,15),new DateTime(2026,5,16)  );


            Console.WriteLine(mytrip.TimeSpanCalculateDuration());

            

        }
    }
}
