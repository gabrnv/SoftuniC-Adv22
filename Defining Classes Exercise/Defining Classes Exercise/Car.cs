using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumption;
        }
        public Car(string model)
        {
            this.model = model;
        }
        public string Model { get { return this.model; } set { this.model = value; } }
        public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return this.fuelConsumptionPerKilometer; } set { this.fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return this.travelledDistance; } set { this.travelledDistance = value; } }

        public bool CanCarDrive(double distance)
        {
            double fuelUsed = distance * fuelConsumptionPerKilometer;
            double fuel = this.FuelAmount;
            if(fuel - fuelUsed >= 0)
            {
                this.FuelAmount -= fuelUsed;
                this.TravelledDistance += distance;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
        }

    }
}
