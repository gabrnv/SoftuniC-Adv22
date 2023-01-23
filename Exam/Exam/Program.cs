using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            int croissant = 0;
            int muffin = 0;
            int baguet = 0;
            int bagel = 0;
            while(flour.Count > 0 && water.Count > 0)
            {
                double cWater = water.Peek();
                double cFlour = flour.Peek();
                double wRatio = (cWater * 100) / (cWater + cFlour);
                if(wRatio == 50)
                {
                    croissant++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if(wRatio == 40)
                {
                    muffin++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if(wRatio == 30)
                {
                    baguet++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if(wRatio == 20)
                {
                    bagel++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    bool isWaterMore = cWater > cFlour;
                    if(isWaterMore)
                    {
                        croissant++;
                        flour.Pop();
                        water.Dequeue();
                        water.Enqueue(cWater - cFlour);
                    }
                    else
                    {
                        croissant++;
                        water.Dequeue();
                        flour.Pop();
                        flour.Push(cFlour - cWater);
                    }
                }


            }
            Dictionary<string, int> baked = new Dictionary<string, int>();
            baked.Add("Bagel", bagel);
            baked.Add("Baguette", baguet);
            baked.Add("Croissant", croissant);
            baked.Add("Muffin", muffin);
            var sortedBakes = from entry in baked orderby entry.Value descending select entry;
            

            baked.Values.OrderByDescending(x => x);
            baked.Keys.OrderBy(x => x);
            
            foreach (var item in sortedBakes)
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            if(water.Count <= 0)
            {
                Console.WriteLine($"Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if (flour.Count <= 0)
            {
                Console.WriteLine($"Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
