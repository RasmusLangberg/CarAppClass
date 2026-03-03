using System.Security.Cryptography;

namespace CarAppClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int km = 0;
            
            Car MyCar1 = new Car("Ford","Cmax",2017,'m',190000, "diesel",false, 24.5);
            Car MyCar2 = new Car("Ford", "Kuga", 2019, 'm', 120000, "diesel", false, 25.5);

            // 100 km
            MyCar1.Drive(100);
            MyCar2.Drive(100);

            // km, afstand
            Console.WriteLine("Det kommeer til at koste" + "" + MyCar1.CalculateTripPrice(10) + "" + "kr");
            Console.WriteLine("Det kommeer til at koste" + "" + MyCar2.CalculateTripPrice(15)+ "" +"kr");

            MyCar1.GetCarDetails();
            MyCar2.GetCarDetails();

            

        }
    }
}
