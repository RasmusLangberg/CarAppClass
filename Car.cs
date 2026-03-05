using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

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
        public double _KmPerLiter { get;}
        public FuelType FuelType {  get; set; }
        private double _LiterPrice { get; set; }

        private List<Trip> _Triplist { get; set; }

        public Car(string brand, string model, int year, char gearType, int odometer, bool isengineon, FuelType fuelType, double kmPerLiter, double LiterPrice)
        {

            _Brand = brand;
            _Model = model;
            _Year = year;
            _GearType = gearType;
            _Odometer = odometer;
            _IsEngineOn = isengineon;
            FuelType = fuelType;
            _KmPerLiter = kmPerLiter;
            _LiterPrice = LiterPrice;
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

       
        public void CarDetails()
        {
            Console.WriteLine($"bilmoddelen er en {_Brand}, {_Model}. Bilen er fra {_Year} og har {_GearType} Gearkasse. Bilen har kørt {_Odometer}, og bruger {_FuelType} som brændstof. bilen køre {_KmPerLiter} pr. liter.");
        }

       
      



    }
}
