using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> stack = new Queue<string>(input);
            int sum = 0;
            while(stack.Count > 0)
            {
                if(stack.Peek() == "+")
                {
                    stack.Dequeue();
                    sum += int.Parse(stack.Peek());
                    stack.Dequeue();
                }
                else if(stack.Peek() == "-")
                {
                    stack.Dequeue();
                    sum -= int.Parse(stack.Peek());
                    stack.Dequeue();
                }
                else
                {
                    sum += int.Parse(stack.Peek());
                    stack.Dequeue();
                }
            }
            Console.WriteLine(sum);
        }
    }
}
