using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int height = input[0];
            int width = input[1];

            int[,] matrix = new int[height, width];

            for (int row = 0; row < height; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int maximalSum = int.MinValue;
            int maximalIndexR = int.MinValue;
            int maximalIndexC = int.MinValue;
            for (int row = 0; row < height - 2; row++)
            {
                for (int col = 0; col < width - 2; col++)
                {
                    
                    int currentSum = 
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] ;
                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        maximalIndexC = col;
                        maximalIndexR = row;
                    }

                }
            }

            Console.WriteLine($"Sum = {maximalSum}");

            Console.WriteLine($"{matrix[maximalIndexR, maximalIndexC]} {matrix[maximalIndexR, maximalIndexC + 1]} {matrix[maximalIndexR, maximalIndexC + 2]}");
            Console.WriteLine($"{matrix[maximalIndexR + 1, maximalIndexC]} {matrix[maximalIndexR + 1, maximalIndexC + 1]} {matrix[maximalIndexR + 1, maximalIndexC + 2]}");
            Console.WriteLine($"{matrix[maximalIndexR + 2, maximalIndexC]} {matrix[maximalIndexR + 2, maximalIndexC + 1]} {matrix[maximalIndexR + 2, maximalIndexC + 2]}");
        }
    }
}
