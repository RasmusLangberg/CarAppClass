using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            FuelCar fuelCar = new FuelCar("Ford","Cmax",2017,'m',"EK23566",199.875,50.0,50.0,24.4);

            ElectricCar electricCar = new ElectricCar("ford","mustang march e",2019,'a',"BL86665",50.000,351.4,351.4,50.1);



            fuelCar.TurnEngineOn();

            electricCar.TurnEngineOn();



            Trip trip1 = new Trip(fuelCar, 80, DateTime.Now, DateTime.Now.AddHours(1));

            Trip trip2 = new Trip(electricCar, 60, DateTime.Now, DateTime.Now.AddHours(1));



            fuelCar.Drive(trip1);

            electricCar.Drive(trip2);



            Console.WriteLine($"FuelCar odometer:    {fuelCar._odometer} km");

            Console.WriteLine($"Fuel level:         {fuelCar.FuelLevel:F1} L");



            Console.WriteLine($"ElectricCar odometer: {electricCar._odometer} km");

            Console.WriteLine($"Battery level:        {electricCar.BatteryLevel:F1} kWh");





        }

    }
} 