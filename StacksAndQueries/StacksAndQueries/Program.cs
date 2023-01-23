using System;
using System.Collections.Generic;

namespace StacksAndQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
