using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();
            while(command!="end")
            {
                string[] splittedCom = command.Split(" ").ToArray();
                if(splittedCom[0] == "add")
                {
                    int first = int.Parse(splittedCom[1]);
                    int second = int.Parse(splittedCom[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else if(splittedCom[0] == "remove")
                {
                    if(int.Parse(splittedCom[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(splittedCom[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
