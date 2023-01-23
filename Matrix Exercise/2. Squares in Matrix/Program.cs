using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] strings = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = strings[col];
                }
            }

            int squares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    string currLet = matrix[row, col];
                    string nextLet = matrix[row, col + 1];
                    string downLet = matrix[row + 1, col];
                    string downNextLet = matrix[row + 1, col + 1];

                    if(currLet == nextLet && downLet == downNextLet && currLet == downLet)
                    {
                        squares++;
                    }
                }
            }

            Console.WriteLine(squares);

        }
    }
}
