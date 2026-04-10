using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class ElectricCar : Car
    {
        public double BatteryCapacity;
        public double BatteryLevel;
        public double KmPerKwh;

        public ElectricCar(string brand, string model, int year,char gear,string licenseplate ,double odometer, double batteryCapacity, double batteryLevel, double kmPerKwh) : base(brand, model, year, gear,licenseplate, odometer)
        {
            BatteryCapacity = batteryCapacity;
            BatteryLevel = batteryLevel;
            KmPerKwh = kmPerKwh;

            BatteryLevel = BatteryCapacity;
        }

        public override void UpdateEnergyLevel(double km)
        {
            BatteryLevel -= km / KmPerKwh;
        }

        public void Chargel(double kwh)
        {
            if (kwh > BatteryCapacity - BatteryLevel)
            {
                Console.WriteLine("du kan ikke fylde mere på end der kan være af kapacitet");
            }
            else if (kwh < (BatteryCapacity - BatteryLevel) ) 
            { 
                BatteryLevel += kwh;
            
            } 
        }
        
       public override string ToString()
        {
            return $"ElectricCar: {Brand}{Model}{Year}{Gear}{Licenseplate}{Odometer}{KmPerKwh}{BatteryCapacity}{BatteryLevel}";
  
        }

        public static ElectricCar FromString(string data)
        {
            string[] parts = data.Split(',');
            string Brand = parts[0];
            string model = parts[1];
            int year = int.Parse(parts[2]);
            char gear = char.Parse(parts[3]);
            string licenseplate = parts[4];
            int odometer = int.Parse(parts[5]);
            double KmPerKwh = double.Parse(parts[6]);
            double BatteryCapacity = double.Parse(parts[7]);
            double BatteryLevel = double.Parse(parts[8]);
         

            return new ElectricCar(Brand, model, year, gear, licenseplate, odometer, KmPerKwh, BatteryLevel, BatteryCapacity );

        }

    }
}
