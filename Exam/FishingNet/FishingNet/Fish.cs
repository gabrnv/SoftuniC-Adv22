﻿namespace FishingNet
{
    public class Fish
    {
        public Fish(string fishType, double lenght, double weight)
        {
            FishType = fishType;
            Lenght = lenght; 
            Weight = weight;
        }
        public string FishType { get; set; }
        public double Lenght { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"There is a {FishType}, {Lenght} cm. long, and {Weight} gr. in weight.";
        }
    }
}
