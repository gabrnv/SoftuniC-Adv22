﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            numbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
