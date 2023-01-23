using System;
using System.Linq;
using System.Collections.Generic;

namespace Stacks_And_Queues_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];
            int[] nNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> stack = new Queue<int>(nNums);
            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
