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





            // Program.cs — test af InMemoryCarRepository 

            ICarRepository repo = new InMemoryCarRepository();



            repo.Add(new FuelCar("Ford", "Cmax", 2017, 'm', "EK23566", 200000, 50.0, 25.2, 24.4));

            repo.Add(new ElectricCar("ford", "mustang march e", 2019, 'a', "BL86665", 50.0, 351.4, 351.4, 50.1));

            // Hent alle og udskriv 

            foreach (Car car in repo.GetAll())

                Console.WriteLine($"{car.Brand} {car.Model} — {car.Licenseplate}");



            // Hent en specifik bil 

            Car found = repo.GetByLicensePlate("AB12345");

            Console.WriteLine(found != null ? $"Fundet: {found.Brand}" : "Ikke fundet");



            // Slet en bil og verificer 

            repo.Delete("AB12345");

            Console.WriteLine($"Antal biler: {repo.GetAll().Count()}"); // 1 


            repo.






        }
    }
}