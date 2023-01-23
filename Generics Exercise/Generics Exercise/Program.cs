using System;
using System.Linq;

namespace Generics_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                var value = double.Parse(Console.ReadLine());
                box.Items.Add(value);
            }
            double comperator = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountGreaterThan(comperator));
        }
    }
}
