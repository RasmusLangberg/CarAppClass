using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class FuelCar : Car, ISellable, IInsureable
    {
        public double TankCapacity { get; private set; }
        public double FuelLevel { get; private set; }
        public double KmPerLiter { get; private set; }
        public double Price {  get; private set; }
        public string RegistrationNumber
        {
            get { return Licenseplate; }
        }



        public FuelCar(string brand, string model, int year, char gear,string licenseplate, double odometer, double tankCapacity, double fuelLevel, double kmPerLiter) : base(brand, model, year, gear,licenseplate,odometer)
        { 
            TankCapacity = tankCapacity;
            FuelLevel = fuelLevel;
            KmPerLiter = kmPerLiter;

            FuelLevel = TankCapacity;
          
        }

        public void GetSalesSummary()
        {
            Console.WriteLine($"MÆRKE{Brand}MODEL{Model}FRA{Year}GEARTYPE{Gear}NR PLADE:{Licenseplate}KØRT:{_odometer}KMPL{KmPerLiter}PRIS{Price}");
           
        }





        public override void UpdateEnergyLevel(double km)
        {
            FuelLevel -= km / KmPerLiter;
        }

        public void Refuel(double liters)
        {
            if (liters > (TankCapacity - FuelLevel) )
            {
                Console.WriteLine("du kan ikke fylde mere på end der kan være af kapacitet");
            }
            else if (liters < (TankCapacity - FuelLevel) )
            {
                FuelLevel += liters;

            }
        }

        static override string ToString()
        {
            return $"FuelCar: {Brand}{Model}{Year}{Gear}{LicensePlate}{Odometer}{Price}{KmPerLiter}{TankCapacity}{RegistrationNumber}{FuelLevel}"

        }














    }
}
