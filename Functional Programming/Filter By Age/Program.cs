using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                people.Add(input[0], int.Parse(input[1]));
            }
            string condition = Console.ReadLine();
            bool isCondition = IsCondOld(condition);
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Dictionary<string, int> selectedPlp = SelectPeople(isCondition, people, age);
            printPeople(format, selectedPlp);
        }

        public static bool IsCondOld(string condition)
        {
            return condition == "older";
        }

        public static Dictionary<string, int> SelectPeople(bool isCond, Dictionary<string, int> people, int age)
        {
            Dictionary<string, int> selectedPeople = new Dictionary<string, int>();
            if(isCond == true)
            {
                foreach (var kvp in people)
                {
                    if(kvp.Value >= age)
                    {
                        selectedPeople.Add(kvp.Key, kvp.Value);
                    }
                }
                return selectedPeople;
            }
            else
            {
                foreach (var kvp in people)
                {
                    if (kvp.Value < age)
                    {
                        selectedPeople.Add(kvp.Key, kvp.Value);
                    }
                }
                return selectedPeople;
            }
        }
        
        public static void printPeople(string format, Dictionary<string, int> people)
        {
            switch(format)
            {
                case "name age":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                    break;
                case "age name":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Value} - {kvp.Key}");
                    }
                    break;
                case "name":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Key}");
                    }
                    break;
                case "age":
                    foreach (var kvp in people)
                    {
                        Console.WriteLine($"{kvp.Value}");
                    }
                    break;
            }
        }
    }
}
