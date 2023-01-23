using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<double, int>> students = new Dictionary<string, Dictionary<double, int>>();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);
                if(!students.ContainsKey(name))
                {
                    students.Add(name, new Dictionary<double, int>());
                   
                }
                students[name]. += grade;
                
            }

            foreach (var item in students)
            {
                
            }
        }
    }
}
