using System;
using System.Collections.Generic;
using System.Text;
using static CarAppClass.Fueltype;

namespace CarAppClass
{
    internal class Trip
    {

        private double Distance;
        private DateTime TripDate;
        private DateTime StartTime;
        private DateTime EndTime;
        private Car _car;

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

            usedfuel = Distance / _car._KmPerLiter;


            return usedfuel;
        }

        public double CalculateTripPrice(double literPrice, double usedfuel, string _FuelType)
        {
            
            
           

            if (literPrice > 0)
            { usedfuel *= literPrice; }





            return literPrice;
        }







    }
}
