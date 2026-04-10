using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            FuelCar Ford = new FuelCar("Ford","Cmax",2017,'m',"EK23566",199.875,50.0,50.0,24.4);

            ElectricCar FordE = new ElectricCar("ford","mustang march e",2019,'a',"BL86665",50.000,351.4,351.4,50.1);



            fuelCar.TurnEngineOn();

            electricCar.TurnEngineOn();



            Trip trip1 = new Trip(Ford, 80, DateTime.Now, DateTime.Now.AddHours(1));

            Trip trip2 = new Trip(FordE, 60, DateTime.Now, DateTime.Now.AddHours(1));



            Ford.Drive(trip1);

            FordE.Drive(trip2);



          


            Console.WriteLine($"{Ford.ToString}");


        }

    }
} 