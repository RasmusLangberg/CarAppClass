using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class Car
    {
        // Private felter (indkapsling)
        public string _brand{ get; private set; }
        public string _model{ get; private set; }
        public int _year{ get; private set; }
        public char _gear{ get; private set; }
        public int _odometer{ get; private set; }
        public string _fuelType{ get; private set; }
        public bool _isEngineOn { get; private set; }
        public double _kmPerLiter {  get; private set; }

        // Konstruktør
        public Car(string brand, string model, int year, char gear, string fuelType, double kmPerLiter)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            _fuelType = fuelType;
            _kmPerLiter = kmPerLiter > 0 ? kmPerLiter : 1;
            _odometer = 0;
            _isEngineOn = false;
        }

        // Properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 1886)
                    _year = value;
            }
        }

        public char Gear
        {
            get { return _gear; }
            set { _gear = value; }
        }

        // Read-only
        public int Odometer
        {
            get { return _odometer; }
        }

        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        public bool IsEngineOn
        {
            get { return _isEngineOn; }
            set { _isEngineOn = value; }
        }

        public double KmPerLiter
        {
            get { return _kmPerLiter; }
            set
            {
                if (value > 0)
                    _kmPerLiter = value;
            }
        }

        // Metoder
        public void Drive(double distance)
        {
            if (_isEngineOn && distance > 0)
            {
                _odometer += (int)distance;
            }
        }

        // fuelType-parameteren er ikke nødvendig mere – bruger _fuelType
        public double CalculateTripPrice(double distance, double literPrice)
        {
            double litersUsed = distance / _kmPerLiter;
            return litersUsed * literPrice;
        }

        public string GetCarDetails()
        {
            return $"{_brand} {_model} ({_year}) | Brændstof: {_fuelType} | " +
                   $"Gear: {_gear} | Odometer: {_odometer} km | " +
                   $"Motor: {(_isEngineOn ? "Tændt" : "Slukket")}";
        }
    }


}

