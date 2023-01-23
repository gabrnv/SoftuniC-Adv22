using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int leftDiag = 0;
            int rightDiag = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                leftDiag += matrix[i, i];
            }
            int row = 0;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                rightDiag += matrix[row, i];
                row++;
            }

            Console.WriteLine(Math.Abs(leftDiag - rightDiag));
        }
    }
}
