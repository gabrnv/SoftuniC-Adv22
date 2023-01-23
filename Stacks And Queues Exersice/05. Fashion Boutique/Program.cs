using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int valueSum = 0;
            Stack<int> stack = new Stack<int>(numbers);

            while (stack.Count > 0) 
            {
                if(valueSum < rackCapacity)
                {
                    valueSum += item;
                }
                else if(valueSum == rackCapacity)
                {
                    if(stack.Count != 0)
                    {
                        valueSum = 0;
                        racks++;
                    }
                }
                else
                {
                    racks++;
                    valueSum = 0;
                    valueSum += item;
                }
            }

            Console.WriteLine(racks + 1);
        }
    }
}
