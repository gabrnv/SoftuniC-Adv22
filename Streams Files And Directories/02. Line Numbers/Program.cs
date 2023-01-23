using System;
using System.IO;

namespace _02._Line_Numbers
{
    internal class Program
    {
        public static void Main()
        {
            string inputFilePath = @"../../../input.txt";
            string outputFilePath = @"../../../output.txt";

            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            int i = 1;
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            string inputLine = reader.ReadLine();
            while (inputLine != null)
            {
                writer.WriteLine($"{i}. {inputLine}");
                inputLine = reader.ReadLine();
                i++;
            }
            reader.Close();
            writer.Close();
        }
    }
}
