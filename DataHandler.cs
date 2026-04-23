using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppClass
{
    internal class DataHandler
    {
        public string Filepath { get; set; } 

        public DataHandler(string filepath)
        {
            Filepath = filepath;
        }

        public void SaveCarsToFile(List<Car> Cars)
        {

            using (StreamWriter sw = new StreamWriter(Filepath))
            {
                foreach (Car car in Cars)
                {
                    sw.WriteLine(car.ToString()); // Gemmer hver medarbejder som en linje i filen
                }
            }
        }

        public List<Car> LoadCarsFromFile(List<Car> cars)
        {
            List<Car> cars = new List<Car>();
            using (StreamReader sr = new StreamReader(Filepath))
            {

                string line;
            
                while ((line = sr.ReadLine()) != null)
                {
                    if(!string.IsNullOrEmpty(line))
                    {
                        string[] parts = line.Split(',');
                        string type = parts[0];


                        if(type == "FuelCar")
                        {
                            cars.Add(FuelCar.FromString(line));
                        }

                        if (type == "ElecticCar")
                        {
                            cars.Add(ElectricCar.FromString(line));
                        }

                        
                    }
                }
                return cars;
            }
                

                


            
        }






        
    }
}
