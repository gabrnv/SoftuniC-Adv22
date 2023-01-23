using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];
            int[,] garden = FillGarden(n, m);
            List<int> planted = new List<int>();
            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow")
            {
                int row = input.Split().Select(int.Parse).ToArray()[0];
                int col = input.Split().Select(int.Parse).ToArray()[1];
                if (DoesPlaceExist(row, col, garden))
                {
                    planted.Add(row);
                    planted.Add(col);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < planted.Count; i += 2)
            {
                int row = planted[i];
                int col = planted[i++];
                garden = Bloom(row, col, garden);
            }
            PrintGarden(garden);
        }

        public static int[,] FillGarden(int n, int m)
        {
            int[,] garden = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < m; x++)
                {
                    garden[i, x] = 0;
                }
            }
            return garden;
        }
        public static int[,] Bloom(int row, int col, int[,] garden)
        {

            for (int y = 0; y < garden.GetLength(0); y++)
            {
                int flower = garden[y, col];
                if (flower == 0)
                {
                    garden[y, col]++;
                }
                else if (flower == 1 && y != row)
                {
                    garden[y, col]++;
                }
            }
            for (int y = 0; y < garden.GetLength(1); y++)
            {
                int flower = garden[row, y];
                if (flower == 0)
                {
                    garden[row, y]++;
                }
                else if (flower == 1 && y != row)
                {
                    garden[row, y]++;
                }
            }

            return garden;
        }
        public static void PrintGarden(int[,] garden)
        {
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int x = 0; x < garden.GetLength(1); x++)
                {
                    Console.Write($"{garden[i, x]} ");
                }
                Console.WriteLine();
            }
        }
        public static bool DoesPlaceExist(int row, int col, int[,] garden)
        {
            int rows = garden.GetLength(0);
            int cols = garden.GetLength(1);
            if (row <= rows && row >= 0 && col <= cols && col >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
