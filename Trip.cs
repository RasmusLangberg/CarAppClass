using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    public class Trip
    {

        public double Distance {  get; private set; }
        public DateTime TripDate { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
       
        private Car _car;

        public List<Trip> trips = new List<Trip>();

        public Trip(Car car, double distance, DateTime startTime, DateTime endTime)
        {

            _car = car;

            Distance = distance;

            StartTime = startTime;

            EndTime = endTime;

            TripDate = startTime;

        }

        public TimeSpan TimeSpanCalculateDuration()
        {
            TimeSpan TimeDuration = EndTime-StartTime;

            return TimeDuration;
        }

        public double CalculateFuelUsed()
        {
            double usedfuel = 0.0;

            usedfuel = Distance;


            return usedfuel;
        }

        public double CalculateTripPrice(double literPrice, double usedfuel, string _FuelType)
        {
            usedfuel *= literPrice;
            return usedfuel;
        }

        public string GetTripDetails(double Distance, double usedfuel, TimeSpan TimeDuration)
        {
            return $"Turen du kørte var på {Distance}km. Du brugte{usedfuel:F2}. Det tog {TimeDuration}";
        }





    }
}
