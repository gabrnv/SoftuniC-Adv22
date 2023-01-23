using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }
        public List<Fish> Fish { get; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Fish.Count; } }
        public string AddFish(Fish fish)
        {
            if(this.Count <= this.Capacity)
            {
                if (fish.FishType != null && fish.FishType != " " && fish.Weight > 0)
                {
                    Fish.Add(fish);
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }
                else
                {
                    return "Invalid fish.";
                }
            }
            else
            {
                return "Fishing net is full.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            Fish fish = Fish.FirstOrDefault(x => x.Weight == weight);
            if (fish != null)
            {
                Fish.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Fish GetFish(string fishType)
        {
            return Fish.FirstOrDefault(x => x.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            Fish biggestFish = new Fish("", int.MinValue, 0);
            foreach (var fish in Fish)
            {
                if (fish.Lenght > biggestFish.Lenght)
                {
                    biggestFish = fish;
                }
            }
            return biggestFish;

        }

        public string Report()
        {
            List<Fish> sorted = Fish.OrderByDescending(x => x.Lenght).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in sorted)
            {
                sb.AppendLine($"{fish}");
            }
            return sb.ToString().Trim();
        }
    }
}
