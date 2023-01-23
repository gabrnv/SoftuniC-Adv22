using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Even_Lines
{
    internal class Program
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            StreamReader reader = new StreamReader(inputFilePath);
            int i = 0;
            string line = reader.ReadLine();
            while(line != null)
            {
                line = string.Join(" ", line.Split().Reverse());
                if (i % 2 == 0)
                {
                    foreach(char c in line)
                    {
                        if(c == '.' || c == ',' || c == '-' || c == '!' || c == '?')
                        {
                            line.Replace(c, '@');
                        }
                    }    
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();   
                i++;
            }

        }

    }
}
