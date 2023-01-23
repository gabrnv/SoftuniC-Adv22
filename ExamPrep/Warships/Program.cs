using System;
using System.Collections.Generic;
using System.Linq;

namespace Warships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] attacks = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] field = new char[n,n];
            int totalShipsDestryed = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char[] toAdd = input.ToCharArray()
        .Where(c => !Char.IsWhiteSpace(c))
        .ToArray();
                for (int x = 0; x < n; x++)
                {
                    field[i, x] = toAdd[x];
                }
            }
            for (int i = 0; i < attacks.Length-1; i+= 2)
            {
                int x = attacks[i];
                int y = attacks[i+1];
                if(isInRange(x,y,field))
                {
                    char position = field[x,y];
                    if(position != '#' && position != '*')
                    {
                        field[x,y] = 'X';
                        totalShipsDestryed++;
                    }
                    else if(position == '#')
                    {
                        BombPlace(ref field, x - 1, y, ref totalShipsDestryed);
                        BombPlace(ref field, x + 1, y, ref totalShipsDestryed);
                        BombPlace(ref field, x, y-1, ref totalShipsDestryed);
                        BombPlace(ref field, x, y+1, ref totalShipsDestryed);
                        BombPlace(ref field, x-1, y+1, ref totalShipsDestryed);
                        BombPlace(ref field, x - 1, y-1, ref totalShipsDestryed);
                        BombPlace(ref field, x + 1, y-1, ref totalShipsDestryed);
                        BombPlace(ref field, x + 1, y+1, ref totalShipsDestryed);

                    }
                }
                
            }
            int playerOne = 0;
            int playerTwo = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {
                    if(field[i,x] == '<')
                    {
                        playerOne++;
                    }
                    else if(field[i,x] == '>')
                    {
                        playerTwo++;
                    }
                }
            }
            if (playerTwo > 0 && playerOne > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");
            }
            else
            {
                if (playerOne > playerTwo)
                {
                    Console.WriteLine($"Player One has won the game! {totalShipsDestryed} ships have been sunk in the battle.");
                }
                else if (playerTwo > playerOne)
                {
                    Console.WriteLine($"Player Two has won the game! {totalShipsDestryed} ships have been sunk in the battle.");
                }
            }
            
            

        }

        public static bool isInRange(int x, int y, char[,] maze)
        {
            if (x < maze.GetLength(0) && y < maze.GetLength(1) && x >= 0 && y >= 0)
            {
                return true;
            }
            return false;
        }
        public static void BombPlace(ref char[,] field, int x, int y, ref int bombedPlaces)
        {
            if(isInRange(x,y,field))
            {
                if(field[x,y] == '<' || field[x,y] == '>')
                {
                    bombedPlaces++;
                }
                if(field[x, y] != '*')
                {
                    field[x, y] = 'X';
                }
            }
        }
    }
}
