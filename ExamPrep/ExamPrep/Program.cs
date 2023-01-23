using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputTasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> tasks = new Stack<int>(inputTasks);
            int[] inputThreads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> threads = new Queue<int>(inputThreads);
            int taskToKill = int.Parse(Console.ReadLine());
            while(threads.Count != 0)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();
                if(task == taskToKill && thread >= task)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
                    Console.WriteLine(String.Join(" ", threads));
                    break;
                }
                else if(thread >= task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }

        }
    }
}
