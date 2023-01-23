using System;

namespace SnakeNYT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            while (true)
            {
                System.Threading.Thread.Sleep(100);
                if(ConsoleKey.s)
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"@");
                x++;
            }
        }
    }
}
