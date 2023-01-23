using System;
using System.Linq;

namespace Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray().Select(x => x * 1.2).ToArray();
            Console.WriteLine(string.Join("\n", numbers.Select(x => $"{x:f2}")));
        }
    }
}
