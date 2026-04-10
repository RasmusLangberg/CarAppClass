using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public class Program
    {
        static void Main(string[] args)
        {


            DataHandler datahandler = new DataHandler("Cars.txt");

            FuelCar Ford = new FuelCar("Ford", "Cmax", 2017, 'm', "EK23566", 200000, 50.0, 25.2, 24.4);

            ElectricCar FordE = new ElectricCar("ford", "mustang march e", 2019, 'a', "BL86665", 50.0, 351.4, 351.4, 50.1);

            FuelCar FordTruck = new FuelCar("Ford", "F150", 2017, 'm', "CP12345", 140000, 55, 55, 16.0);


            List<Car> cars = new List<Car>();
            {
                cars.Add(Ford);
                cars.Add(FordE);
                cars.Add(FordTruck);
            }

            datahandler.SaveCarsToFile(cars);

        }

    }
} 