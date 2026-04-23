using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal class FileCarRepository
    {

        public string FilePath { get; set; }



        public FileCarRepository(string filePath)

        {

            FilePath = filePath;

            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }

        }



        public IEnumerable<Car> GetAll()

        {

            // Læs alle linjer med StreamReader 

            // For hver linje: split paa komma, tjek type (parts[0]) 

            // Kald FuelCar.FromString() eller ElectricCar.FromString() 

        }



        public Car GetByLicensePlate(string licensePlate)

        {

            // Brug GetAll() og find bilen med den givne nummerplade 

        }



        public void Add(Car car)

        {

            // Skriv car.ToString() som en ny linje med StreamWriter (append) 

        }



        public void Update(Car car)

        {

            // Indlæs alle biler, find og erstat, skriv hele filen igen 

        }



        public void Delete(string licensePlate)

        {

            // Indlæs alle, fjern bilen, skriv hele filen igen 

        }


    }
}
