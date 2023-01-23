using System;
using System.Collections.Generic;
using System.Linq;
namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int i = 1;
            foreach (var item in queue)
            {
                if(item % 2 == 0)
                {
                    Console.Write($"{item}");
                    if (i < queue.Count)
                    {
                        Console.Write($", ");
                    }
                }
                i++;
            }
        }
    }
}
