using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(", ");
            string command = Console.ReadLine();
            Queue<string> songs = new Queue<string>(strings);
            while(songs.Count > 0)
            {
                string[] splittedCom = command.Split(" ", 2);

                switch(splittedCom[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        if(!songs.Contains(splittedCom[1]))
                        {
                            songs.Enqueue(splittedCom[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{splittedCom[1]} is already contained!");
                        }
                        break;
                    case "Show":
                        int i = 0;
                        foreach(string item in songs)
                        {
                            Console.Write($"{item}");
                            if(i < songs.Count - 1)
                            {
                                Console.Write(", ");
                            }
                            i++;
                        }
                        Console.WriteLine();
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
