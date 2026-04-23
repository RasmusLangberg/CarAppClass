using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CarAppClass
{
    internal interface ICarRepository
    {
       
        public IEnumerable<Car> GetAll();

        public Car GetByLicensePlate(string licensePlate); //returnerer én bil eller null
        
        public void Add(Car car);  //tilføjer en bil til lageret

        public void Update(Car car); // opdaterer en eksisterende bil(match på LicensePlate)

        public void Delete(string licensePlate); // sletter en bil baseret på nummerplade


    }
}
