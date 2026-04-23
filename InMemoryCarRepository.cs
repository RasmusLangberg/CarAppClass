using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal class InMemoryCarRepository : ICarRepository
    {

       private readonly List<Car> cars;
        
        
        
        public IEnumerable<Car> GetAll() 
        {  

            return cars;

        }


        public Car GetByLicensePlate(string licensePlate)//returnerer én bil eller null
        {
                return cars.FirstOrDefault(c => c.Licenseplate == licensePlate);
        } 

        public void Add(Car car) //tilføjer en bil til lageret
        {
            cars.Add(car);
        } 

        public void Update(Car car) // opdaterer en eksisterende bil(match på LicensePlate)
        { 
            int i = cars.FindIndex(c => c.Licenseplate == car.Licenseplate);
            if (i != -1)
            {
                cars[i] = car;
            }   
        } 

        public void Delete(string licensePlate) // sletter en bil baseret på nummerplade
        { 
            var car = cars.FirstOrDefault(c => c.Licenseplate == licensePlate);
            if (car != null)
            {
                cars.Remove(car);
            }
        } 





    }
}
