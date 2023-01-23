﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Engine_And_Tires
{
    class Car
    {
        public Car(string Make, int Year, string Model, double FuelQuantity, double FuelConsumption, Engine Engine, Tire[] Tires) : this(Make, Year, Model, FuelQuantity, FuelConsumption)
        {
            this.Engine = Engine;
            this.Tires = Tires;
        }
        public Car(string Make, int Year, string Model, double FuelQuantity, double FuelConsumption) : this(Make, Year, Model)
        {
            this.Make = Make; 
            this.Year = Year;
            this.Model = Model;
            this.FuelQuantity = FuelQuantity;
            this.FuelConsumption = FuelConsumption;
        }
        public Car(string Make, int Year, string Model) : this()
        {
            this.Make = Make;
            this.Year = Year;
            this.Model = Model;
        }
        public Car()
        {
            this.Make = "VW";
            this.Year = 2025;
            this.Model = "Golf";
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        public void Drive(double distance)
        {
            if(this.FuelQuantity - (distance * this.FuelConsumption) > 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}\nConsumption: {this.FuelConsumption}";
        }
    }
}
