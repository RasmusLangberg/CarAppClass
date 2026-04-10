using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class FuelCar : Car, IInsureable
    {
        public double TankCapacity { get; private set; }
        public double FuelLevel { get; private set; }
        public double KmPerLiter { get; private set; }

        public string RegistrationNumber
        {
            get { return Licenseplate; }
        }



        public FuelCar(string brand, string model, int year, char gear,string licenseplate, int odometer, double tankCapacity, double fuelLevel, double kmPerLiter) : base(brand, model, year, gear,licenseplate,odometer)
        { 
            TankCapacity = tankCapacity;
            FuelLevel = fuelLevel;
            KmPerLiter = kmPerLiter;

            FuelLevel = TankCapacity;
          
        }

        public string GetSalesSummary()
        {
            return ($"MÆRKE:{Brand}, MODEL:{Model}, FRA:{Year}, GEARTYPE:{Gear}, NR PLADE:{Licenseplate}, KØRT:{Odometer}, KMPL:{KmPerLiter}");
           
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

         public override string ToString()
        {
            return $"FuelCar: {Brand},{Model},{Year},{Gear},{Licenseplate},{Odometer},{KmPerLiter},{TankCapacity},{RegistrationNumber},{FuelLevel}";

        }

        public static FuelCar FromString(string data)
        {
            string[] parts = data.Split(',');

            string Brand = parts[0];

            string model = parts[1];
            int year = int.Parse(parts[2]);
            char gear = char.Parse(parts[3]);
            string licenseplate = parts[4];
            int odometer = int.Parse(parts[5]);
            double fuelLevel = double.Parse(parts[6]);
            double kmPerLiter = double.Parse(parts[7]);
            double TankCapacity = double.Parse(parts[8]);


            return new FuelCar(Brand, model, year, gear, licenseplate, odometer, fuelLevel,kmPerLiter, TankCapacity);

        }










        
    }
}
 