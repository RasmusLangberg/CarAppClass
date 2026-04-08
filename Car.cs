using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public abstract class Car
    {
        // Private felter (indkapsling)
        public string _brand{ get; set; }
        public string _model{ get; set; }
        public int _year{ get;  set; }
        public char _gear{ get; set; }
        public string Licenseplate { get; set; }
        public double _odometer{ get; set; }
        public bool _IsEngineOn {  get;  set; }
        
       public  List<Trip> trips = new List<Trip>();

        // Konstruktør
        public Car(string brand, string model, int year, char gear,string licenseplate,double odometer)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            Licenseplate = licenseplate;
            _odometer = odometer;
         
            
            _IsEngineOn = false;
            
            
        }

        public bool TurnEngineOn() 
        { 
            _IsEngineOn = true;
            return _IsEngineOn; 
        }

        public abstract void UpdateEnergyLevel(double km);


        public void Drive(Trip trip)

        {

            if (_IsEngineOn == true )

            {

                _odometer += trip.Distance;

                UpdateEnergyLevel(trip.Distance);  // delegeres til underklassen 

                trips.Add(trip);

            }

            else

            {

                Console.WriteLine("Fejl: Motoren er ikke tændt.");

            }

        }

        // fuelType-parameteren er ikke nødvendig mere – bruger _fuelType
        public double CalculateTripPrice(double distance, double literPrice)
        {
            double litersUsed = distance;
            return litersUsed * literPrice;
        }

        public string GetCarDetails()
        {
            return $"{_brand} {_model} ({_year})  | " +
                   $"Gear: {_gear} | Odometer: {_odometer} km | " +
                   $"Motor: {(_IsEngineOn ? "Tændt" : "Slukket")}";
        }



        public List<Trip> GetTripsByDateReturnsDateTime(DateTime Inputdate)
        {
            List<Trip> ResultTrips = new List<Trip>();

            foreach (Trip trip in trips)
            {
                if (trip.TripDate.Date == Inputdate.Date)
                {
                    ResultTrips.Add(trip);
                }

            }
            return ResultTrips;


        }


        public List<Trip> GetTripsInTimeInterval(DateTime start, DateTime end )
        {
            List<Trip> ResultTrips = new List<Trip>();

            foreach(Trip trip in trips)
            {
                if ( trip.StartTime.Hour == start.Hour && trip.EndTime.Hour == end.Hour)
                {
                    Console.WriteLine($"Her er alle de ture som har samme tidspunkt:{trip.StartTime}{trip.EndTime}");                   
                }
                else
                {
                    Console.WriteLine("ingen ture matcher de tidspunkter"); 
                } 
            }
            return ResultTrips;

        }











    }


}

