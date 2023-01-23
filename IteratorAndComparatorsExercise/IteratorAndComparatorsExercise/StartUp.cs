using System;
using System.Collections.Generic;
using System.Linq;

namespace ItAndComp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> customStack = new Stack<int>();
            string input = Console.ReadLine();
            string[] split = input.Split().Skip(1).ToArray();
            string connect = string.Join("", split);
            int[] toPush = connect.Split(",").Select(int.Parse).ToArray();
            customStack.Push(toPush);
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] splittedCommand = command.Split();
                switch (splittedCommand[0])
                {
                    case "Pop":
                        customStack.Pop();
                        break;
                    case "Push":
                        customStack.Push(new int[] { int.Parse(splittedCommand[1]) });
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (int i in customStack)
            {
                Console.WriteLine(i);
            }
            foreach (int i in customStack)
            {
                Console.WriteLine(i);
            }
        }

    }
}
