using System;

namespace Car_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car car2 = new Car(make, year, model);
            Car car3 = new Car(make, year, model, fuelQuantity, fuelConsumption);

            Console.WriteLine(car1.WhoAmI());
            Console.WriteLine(car2.WhoAmI());
            Console.WriteLine(car3.WhoAmI());
        }
    }
}
