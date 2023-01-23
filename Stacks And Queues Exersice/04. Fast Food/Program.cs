using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(orders.Max());
            Queue<int> queue = new Queue<int>(orders);
            bool isOrderNoice = true;
            int completedOrders = 0;
            int totalOrders = queue.Sum();
            for(int i = 0; i < queue.Count; i++)
            {
                if (food - queue.Peek() >= 0)
                {
                    food -= queue.Peek();
                    completedOrders += queue.Peek();
                    queue.Dequeue();
                    i--;
                }
                else
                {
                    isOrderNoice = false;
                    break;
                }
            }
            if(isOrderNoice)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                foreach(int item in queue)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
