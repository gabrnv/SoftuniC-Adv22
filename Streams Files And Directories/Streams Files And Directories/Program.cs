using System;
using System.IO;

namespace Streams_Files_And_Directories
{
    public class OddLines
    {
        public static void Main()
        {
            string inputFilePath = @"D:\SoftuniC#Adv22\Streams Files And Directories\Streams Files And Directories\input.txt";
            string outputFilePath = @"../../../output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            int i = 0;
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            string inputLine = reader.ReadLine();
            while(inputLine != null)
            {
                if(i % 2 != 0)
                {
                    writer.WriteLine(inputLine);
                }
                i++;
                inputLine = reader.ReadLine();
            }
            reader.Close();
            writer.Close();
        }

    }
}
