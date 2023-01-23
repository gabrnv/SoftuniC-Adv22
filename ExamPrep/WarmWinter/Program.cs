using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hatInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> hats = new Stack<int>(hatInput);
            int[] scarfInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> scarfs = new Queue<int>(scarfInput);
            List<int> sets = new List<int>();
            while(hats.Count > 0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                if (hat > scarf)
                {
                    sets.Add(hat+scarf);
                    scarfs.Dequeue();
                    hats.Pop();
                }
                else if(hat == scarf)
                {
                    scarfs.Dequeue();
                    hat++;
                    hats.Pop();
                    hats.Push(hat);
                }
                else
                {
                    hats.Pop();
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(String.Join(" ", sets));
        }
    }
}
