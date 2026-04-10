using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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
        
        static override string ToString()
        {
            return $"ElectricCar: {Brand}{Model}{Year}{Gear}{LicensePlate}{Odometer}{Price}{KmPerKwh;}{BatteryCapacity}{BatteryLevel}"
  
        }


    }
}
