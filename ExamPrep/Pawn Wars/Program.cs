using System;

namespace Pawn_Wars
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];
            int[] wCords = new int[2];
            int[] bCords = new int[2];
            bool isGameOver = false;
            bool isWhiteTurn = true;
            char whiteCord = ' ';
            char blackCord = ' ';
            bool isWinnerB = false;
            for (int i = 0; i < 8; i++)
            {
                string input = Console.ReadLine();
                for (int x = 0; x < 8; x++)
                {
                    board[i, x] = input[x];
                    if(board[i, x] == 'b')
                    {
                        bCords[0] = i;
                        bCords[1] = x;
                        switch(bCords[1])
                        {
                            case 0:
                                blackCord = 'a';
                                break;
                            case 1:
                                blackCord = 'b';

                                break;
                            case 2:
                                blackCord = 'c';

                                break;
                            case 3:
                                blackCord = 'd';

                                break;
                            case 4:
                                blackCord = 'e';

                                break;
                            case 5:
                                blackCord = 'f';

                                break;
                            case 6:
                                blackCord = 'g';

                                break;
                            case 7:
                                blackCord = 'h';

                                break;
                        }
                    }
                    else if(board[i, x] == 'w')
                    {
                        wCords[0] = i;
                        wCords[1] = x;
                        switch (wCords[1])
                        {
                            case 0:
                                whiteCord = 'a';
                                break;
                            case 1:
                                whiteCord = 'b';

                                break;
                            case 2:
                                whiteCord = 'c';

                                break;
                            case 3:
                                whiteCord = 'd';

                                break;
                            case 4:
                                whiteCord = 'e';

                                break;
                            case 5:
                                whiteCord = 'f';

                                break;
                            case 6:
                                whiteCord = 'g';

                                break;
                            case 7:
                                whiteCord = 'h';

                                break;
                        }
                    }
                }
            }
            while (isGameOver == false)
            {
                if(isWhiteTurn)
                {
                    if(board[wCords[0]-1, wCords[1]-1] == 'b' || board[wCords[0]-1, wCords[1]+1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {blackCord}{bCords[1]+1}.");
                        break;
                    }
                    if(IsInRange(wCords[0]-1, wCords[1]))
                    {
                        wCords[0]--;
                    }
                    else
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {whiteCord}{wCords[1]+1}.");
                        break;
                    }
                    isWhiteTurn = false;
                }
                else
                {
                    if (board[bCords[0] + 1, bCords[1] - 1] == 'b' || board[bCords[0] + 1, bCords[1] + 1] == 'b')
                    {
                        Console.WriteLine($"Game over! Black capture on {whiteCord}{wCords[1] + 1}.");
                        break;
                    }
                    if (IsInRange(bCords[0] - 1, bCords[1]))
                    {
                        bCords[0]++;
                    }
                    else if(bCords[0] == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {blackCord}{bCords[1] + 1}.");
                        break;
                    }
                    isWhiteTurn =true;
                    
                }
            }

        }

        public static bool IsInRange(int x, int y)
            => x < 8 && x >= 0 && y < 8 && y >= 0;

    }
}
