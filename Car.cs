using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal class Car
    {
        private string _Brand { get; set; }
        private string _Model { get; set; }
        private int _Year { get; set; }
        private char _GearType { get; set; }
        private int _Odometer { get; set; }
        private string _FuelType { get; set; }
        private bool _IsEngineOn { get; set; }
        private double _KmPerLiter { get; set; }

        public Car(string brand, string model, int year, char geartype, int odometer, string fueltype, bool isengineon, double kmperliter)
        {
            _Brand = brand;
            _Model = model;
            _Year = year;
            _GearType = geartype;
            _Odometer = odometer;
            _FuelType = fueltype;
            _IsEngineOn = isengineon;
            _KmPerLiter = kmperliter;
        }
        public void StartCar()
        {
            _IsEngineOn = true;
        }
        public void Drive(int km)
        {
           
            if (!_IsEngineOn)
            {
                _Odometer += km;
            }
            else
            {
                Console.WriteLine("motoren er ikke tændt");
            }
        }
        // double fordi den skal retunere en double værdi
        public double CalculateTripPrice(int km)
        {
            double PricePerLiter;

            if (_FuelType == "diesel")
            {
                PricePerLiter = 13;
            }
            else if (_FuelType == "benzin")
            {
                PricePerLiter = 14;
            }
            else PricePerLiter = 0;

            return (km / _KmPerLiter) * PricePerLiter;

        }

       
        public void GetCarDetails()
        {
            Console.WriteLine($"bilmoddelen er en {_Brand}, {_Model}. Bilen er fra {_Year} og har {_GearType} Gearkasse. Bilen har kørt {_Odometer}, og bruger {_FuelType} som brændstof. bilen køre {_KmPerLiter} pr. liter.");
        }


    }
}
