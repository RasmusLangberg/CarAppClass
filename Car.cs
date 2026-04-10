using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public abstract class Car
    {
        // Private felter (indkapsling)
        public string Brand{ get; set; }
        public string Model{ get; set; }
        public int Year{ get;  set; }
        public char Gear{ get; set; }
        public string Licenseplate { get; set; }
        public double Odometer{ get; set; }
        public bool IsEngineOn {  get;  set; }
        
       public  List<Trip> trips = new List<Trip>();

        // Konstruktør
        public Car(string brand, string model, int year, char gear,string licenseplate,double odometer)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Gear = gear;
            Licenseplate = licenseplate;
            Odometer = odometer;
         
            
            IsEngineOn = false;
            
            
        }

        public bool TurnEngineOn() 
        { 
            IsEngineOn = true;
            return IsEngineOn; 
        }

        public abstract void UpdateEnergyLevel(double km);


        public void Drive(Trip trip)

        {

            if (IsEngineOn == true )

            {

                Odometer += trip.Distance;

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
            return $"{Brand} {Model} ({Year})  | " +
                   $"Gear: {Gear} | Odometer: {Odometer} km | " +
                   $"Motor: {(IsEngineOn ? "Tændt" : "Slukket")}";
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

