using System;

namespace SuperMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] maze = new char[n, n];
            int[] mario = new int[2];
            int[] princess = new int[2];
            bool isPrincessSaved = false;
            bool isMarioDead = false;
            for (int i = 0; i < n; i++)
            {
                string cords = Console.ReadLine();
                for (int x = 0; x < n; x++)
                {
                    maze[i, x] = cords[x];
                    if(cords[x] == 'M')
                    {
                        mario[0] = i;
                        mario[1] = x;
                    }
                    else if(cords[x] == 'P')
                    {
                        princess[0] = i;
                        princess[1] = x;
                    }
                }
            }
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (isPrincessSaved == false)
            {
                
                char direction = char.Parse(input[0]);
                int x = int.Parse(input[1]);
                int y = int.Parse(input[2]);

                maze[x, y] = 'B';
                int marioRow = mario[0];
                int marioCol = mario[1];
                switch(direction)
                {
                    case 'W':
                        if(isInRange(marioRow - 1, marioCol, maze) && maze[marioRow - 1, marioCol] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[marioRow - 1, marioCol] = '-';
                            maze[marioRow, marioCol] = '-';
                            break;
                        }
                        if(isInRange(marioRow-1, marioCol, maze) && maze[marioRow-1, marioCol] != 'B')
                        {
                            maze[marioRow - 1, marioCol] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[0]--;
                            lives--;
                        }
                        else if(isInRange(marioRow - 1, marioCol, maze) && maze[marioRow - 1, marioCol] == 'B')
                        {
                            maze[marioRow - 1, marioCol] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[0]--;
                            lives -= 3;
                        }
                        break;
                    case 'S':
                        if (isInRange(marioRow + 1, marioCol, maze) && maze[marioRow + 1, marioCol] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[marioRow + 1, marioCol] = '-';
                            maze[marioRow, marioCol] = '-';
                            break;
                        }
                        if (isInRange(marioRow + 1, marioCol, maze) && maze[marioRow + 1, marioCol] != 'B')
                        {
                            maze[marioRow + 1, marioCol] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[0]++;
                            lives--;
                        }
                        else if (isInRange(marioRow + 1, marioCol, maze) && maze[marioRow + 1, marioCol] == 'B')
                        {
                            maze[marioRow + 1, marioCol] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[0]++;
                            lives -= 3;
                        }
                        break;
                    case 'A':
                        if (isInRange(marioRow, marioCol-1, maze) && maze[marioRow, marioCol-1] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[marioRow, marioCol-1] = '-';
                            maze[marioRow, marioCol] = '-';
                            break;
                        }
                        if (isInRange(marioRow, marioCol - 1, maze) && maze[marioRow, marioCol - 1] != 'B')
                        {
                            maze[marioRow, marioCol-1] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[1]--;
                            lives--;
                        }
                        else if (isInRange(marioRow, marioCol - 1, maze) && maze[marioRow, marioCol - 1] == 'B')
                        {
                            maze[marioRow, marioCol-1] = 'M';
                            mario[1]--;
                            maze[marioRow, marioCol] = '-';
                            lives -= 3;
                        }
                        break;
                    case 'R':
                        if (isInRange(marioRow, marioCol + 1, maze) && maze[marioRow, marioCol + 1] == 'P')
                        {
                            isPrincessSaved = true;
                            maze[marioRow, marioCol + 1] = '-';
                            maze[marioRow, marioCol] = '-';
                            break;
                        }
                        if (isInRange(marioRow, marioCol + 1, maze) && maze[marioRow, marioCol + 1] != 'B')
                        {
                            maze[marioRow, marioCol + 1] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[1]++;
                            lives--;
                        }
                        else if (isInRange(marioRow, marioCol + 1, maze) && maze[marioRow, marioCol + 1] == 'B')
                        {
                            maze[marioRow, marioCol + 1] = 'M';
                            maze[marioRow, marioCol] = '-';
                            mario[1]++;
                            lives -= 3;
                        }
                        break;
                }
                if(isPrincessSaved)
                {
                    break;
                }
                if (lives <= 0)
                {
                    maze[mario[0], mario[1]] = 'X';
                    isMarioDead = true;
                    break;
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            if (isMarioDead)
            {
                Console.WriteLine($"Mario died at {mario[0]};{mario[1]}.");
            }
            else
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives-1}");
            }

            PrintMaze(maze);
        }

        public static void PrintMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int x = 0; x < maze.GetLength(1); x++)
                {
                    Console.Write(maze[i,x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static bool isInRange(int x, int y, char[,] maze)
        {
            if(x <= maze.GetLength(0) && y <= maze.GetLength(1) && x >= 0 && y >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
