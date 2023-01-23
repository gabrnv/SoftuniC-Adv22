using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimentional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rowsI = input[0];
            int colsI = input[1];

            Console.WriteLine(rowsI);
            Console.WriteLine(colsI);
            Console.WriteLine(rowsI);
        }
    }
}
