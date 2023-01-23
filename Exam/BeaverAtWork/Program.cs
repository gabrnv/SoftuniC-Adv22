using System;
using System.Collections.Generic;
using System.Linq;

namespace BeaverAtWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            char[,] pond = new char[n,n];
            int[] beaver = new int[2];
            List<char> branches = new List<char>();
            List<char> collected = new List<char>();
            int droppedBranches = 0;
            int unCollected = 0;
            for (int i = 0; i < n; i++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int x = 0; x < n; x++)
                {
                    pond[i, x] = line[x];
                    if(line[x] == 'B')
                    {
                        beaver[0] = i;
                        beaver[1] = x;
                    }
                    else if(char.IsLower(pond[i,x]))
                    {
                        branches.Add(pond[i,x]);
                    }
                }
            }
            bool doBranchesExist = branches.Count > 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                int row = beaver[0];
                int col = beaver[1];  
                switch(command)
                {
                    case "up":
                        if(IsInRange(row-1, col, pond))
                        {
                            if (char.IsLower(pond[row - 1, col]) && pond[row - 1, col] != '-')
                            {
                                collected.Add(pond[row - 1, col]);
                                branches.Remove(pond[row - 1, col]);
                                pond[row - 1, col] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row - 1;
                                beaver[1] = col;
                                break;
                            }
                            else
                            {
                                pond[row-1, col] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row-1;
                                beaver[1] = col;
                            }
                        }
                        if(IsInRange(row-1, col,pond) == false)
                        {
                            if(collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                                droppedBranches++;
                            }
                            break;
                        }

                        if (IsInRange(row - 2, col, pond) == false && pond[row-1, col] == 'F')
                        {
                            pond[row-1, col] = '-';
                            pond[pond.GetLength(0) - 1, col] = 'B';
                            pond[row, col] = '-';
                            beaver[0] = pond.GetLength(0)-1;
                            beaver[1] = col;
                            break;
                        }
                        else if (IsInRange(row - 2, col, pond) == true && pond[row-1, col] == 'F')
                        {
                            pond[row-1, col] = '-';
                            pond[0, col] = 'B';
                            beaver[0] = 0;
                            beaver[1] = col;
                            pond[row, col] = '-';
                            break;
                        }
                        
                        break;
                    case "down":
                        if (IsInRange(row+1, col, pond) && pond[row + 1, col] != '-')
                        {
                            if (char.IsLower(pond[row + 1, col]))
                            {
                                collected.Add(pond[row + 1, col]);
                                branches.Remove(pond[row + 1, col]);
                                pond[row + 1, col] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row + 1;
                                beaver[1] = col;
                                break;
                            }
                            else
                            {
                                pond[row+1, col] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row+1;
                                beaver[1] = col;
                            }
                        }
                        if (IsInRange(row + 1, col, pond) == false)
                        {
                            if (collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                                droppedBranches++;
                            }
                            break;
                        }

                        if (IsInRange(row + 2, col, pond) == false && pond[row+1, col] == 'F')
                        {
                            pond[row+1, col] = '-';
                            pond[0, col] = 'B';
                            pond[row, col] = '-';
                            beaver[0] = 0;
                            beaver[1] = col;
                            break;
                        }
                        else if (IsInRange(row + 2, col, pond) == true && pond[row+1, col] == 'F')
                        {
                            pond[row+1, col] = '-';
                            pond[pond.GetLength(0)-1, col] = 'B';
                            pond[row, col] = '-';
                            beaver[0] = pond.GetLength(0) - 1;
                            beaver[1] = col;
                            break;
                        }
                        
                        break;
                    case "left":
                        if (IsInRange(row, col - 1, pond))
                        {
                            if (char.IsLower(pond[row, col - 1]) && pond[row, col - 1] != '-')
                            {
                                collected.Add(pond[row, col - 1]);
                                branches.Remove(pond[row, col - 1]);
                                pond[row, col - 1] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = col - 1;
                                break;
                            }
                            else
                            {
                                pond[row, col - 1] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = col - 1;
                            }
                        }
                        if (IsInRange(row, col - 1, pond) == false)
                        {
                            if (collected.Count > 0)
                            {
                                collected.RemoveAt(collected.Count - 1);
                                droppedBranches++;
                            }
                            break;
                        }

                        if (IsInRange(row, col-2, pond) == false && pond[row, col-1] == 'F')
                        {
                            pond[row, col-1] = '-';
                            pond[row, pond.GetLength(1)-1] = 'B';
                            pond[row, col] = '-';
                            beaver[0] = row;
                            beaver[1] = pond.GetLength(1) - 1;
                            break;
                        }
                        else if (IsInRange(row, col-2, pond) == true && pond[row, col-1] == 'F')
                        {
                            pond[row, col--] = '-';
                            pond[row, 0] = 'B';
                            pond[row, col] = '-';
                            beaver[0] = row;
                            beaver[1] = 0;
                            break;
                        }
                        
                        break;
                    case "right":
                        if (IsInRange(row, col+1, pond))
                        {
                            if (char.IsLower(pond[row, col + 1]) && pond[row, col + 1] != '-')
                            {
                                collected.Add(pond[row, col + 1]);
                                branches.Remove(pond[row, col + 1]);
                                pond[row, col + 1] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = col + 1;
                                break;
                            }
                            else
                            {
                                pond[row, col + 1] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = col + 1;
                            }
                        }
                            if (IsInRange(row, col+1, pond) == false)
                            {
                                if (collected.Count > 0)
                                {
                                    collected.RemoveAt(collected.Count - 1);
                                    droppedBranches++;
                                }
                                break;
                            }

                            if (IsInRange(row, col + 2, pond) == false && pond[row, col+1] == 'F')
                            {
                                pond[row, col+1] = '-';
                                pond[row, 0] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = 0;
                                break;
                            }
                            else if (IsInRange(row, col + 2, pond) == true && pond[row, col+1] == 'F')
                            {
                                pond[row, col+1] = '-';
                                pond[row, pond.GetLength(1)-1] = 'B';
                                pond[row, col] = '-';
                                beaver[0] = row;
                                beaver[1] = pond.GetLength(1) - 1;
                                break;
                            }
                        
                        break;
                }
                if(branches.Count <= 0 && doBranchesExist)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (char.IsLower(pond[i, x]))
                    {
                        unCollected++;
                    }
                }
            }
            if (branches.Count <= 0)
            {
                Console.WriteLine($"The Beaver successfully collect {collected.Count} wood branches: {string.Join(", ", collected).Trim()}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {unCollected} branches left.");
            }
            for (int i = 0; i < pond.GetLength(0); i++)
            {
                for (int x = 0; x < pond.GetLength(0); x++)
                {
                    Console.Write(pond[i,x] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsInRange(int row, int col, char[,] pond) => row < pond.GetLength(0) && row >= 0 && col < pond.GetLength(1) && col >= 0;
        
    }
}
