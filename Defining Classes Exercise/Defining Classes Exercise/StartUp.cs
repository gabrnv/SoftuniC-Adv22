using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string model = splitted[0];
                double fuelAmount = double.Parse(splitted[1]);
                double fuelConsumption = double.Parse(splitted[2]);
                cars.Add(model, new Car(model, fuelAmount, fuelConsumption));
            }

            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] splitted = command.Split();
                if(splitted[0] == "Drive")
                {
                    cars[splitted[1]].CanCarDrive(double.Parse(splitted[2]));
                }
                command = Console.ReadLine();

            }

            foreach(var car in cars)
            {
                double fuel = car.Value.FuelAmount;
                string roundedFuel = fuel.ToString("N2");
                Console.WriteLine($"{car.Value.Model} {roundedFuel} {car.Value.TravelledDistance}");
            }
        }
    }
}
