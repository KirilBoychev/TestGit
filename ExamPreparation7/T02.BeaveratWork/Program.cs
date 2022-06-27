using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.BeaveratWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] pond = new char[n,n];

            int rowB = 0;
            int colB = 0;

            Stack<char> woodbranches = new Stack<char>();

            for (int rows = 0; rows < pond.GetLength(0); rows++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries).
                    Select(char.Parse)
                    .ToArray();
                for (int cols = 0; cols < pond.GetLength(1); cols++)
                {
                    pond[rows, cols] = input[cols];
                    if (pond[rows, cols] == 'B')
                    {
                        rowB = rows;
                        colB = cols;
                    }
                }
            }

            int counter = 0;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                for (int rows = 0; rows < pond.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < pond.GetLength(1); cols++)
                    {
                        if (char.IsLower(pond[rows, cols]))
                        {
                            counter++;
                        }
                    }
                }
                if (counter == 0)
                {
                    break;
                }

                if (command == "up")
                {
                    if (rowB++ < 0)
                    {
                        if (woodbranches.Count > 0)
                        {
                            woodbranches.Pop();
                        }
                    }
                    else
                    {
                        pond[rowB, colB] = '-';
                        rowB++;
                        if (char.IsLower(pond[rowB, colB]))
                        {
                            woodbranches.Push(pond[rowB, colB]);
                            pond[rowB, colB] = 'B';
                        }
                        else if (pond[rowB, colB] == 'F')
                        {
                            pond[rowB, colB] = '-';
                            if (rowB == 0)
                            {
                                rowB = pond.GetLength(0) - 1;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    rowB = 0;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                            else
                            {
                                rowB = 0;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    rowB = pond.GetLength(0) - 1;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    if (rowB-- > pond.GetLength(0) - 1)
                    {
                        if (woodbranches.Count > 0)
                        {
                            woodbranches.Pop();
                        }
                    }
                    else
                    {
                        pond[rowB, colB] = '-';
                        rowB--;
                        if (char.IsLower(pond[rowB, colB]))
                        {
                            woodbranches.Push(pond[rowB, colB]);
                            pond[rowB, colB] = 'B';
                        }
                        else if (pond[rowB, colB] == 'F')
                        {
                            pond[rowB, colB] = '-';
                            if (rowB == pond.GetLength(0) - 1)
                            {
                                rowB = 0;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    rowB = pond.GetLength(0) - 1;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                            else
                            {
                                rowB = pond.GetLength(0) - 1;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    rowB = 0;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    if (colB-- > pond.GetLength(1) - 1)
                    {
                        if (woodbranches.Count > 0)
                        {
                            woodbranches.Pop();
                        }
                    }
                    else
                    {
                        pond[rowB, colB] = '-';
                        colB++;
                        if (char.IsLower(pond[rowB, colB]))
                        {
                            woodbranches.Push(pond[rowB, colB]);
                            pond[rowB, colB] = 'B';
                        }
                        else if (pond[rowB, colB] == 'F')
                        {
                            pond[rowB, colB] = '-';
                            if (rowB == pond.GetLength(0) - 1)
                            {
                                colB = 0;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    colB = pond.GetLength(0) - 1;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                            else
                            {
                                colB = pond.GetLength(0) - 1;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    colB = 0;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    if (colB-- < 0)
                    {
                        if (woodbranches.Count > 0)
                        {
                            woodbranches.Pop();
                        }
                    }
                    else
                    {
                        pond[rowB, colB] = '-';
                        colB--;
                        if (char.IsLower(pond[rowB, colB]))
                        {
                            woodbranches.Push(pond[rowB, colB]);
                            pond[rowB, colB] = 'B';
                        }
                        else if (pond[rowB, colB] == 'F')
                        {
                            pond[rowB, colB] = '-';
                            if (colB == 0)
                            {
                                colB = pond.GetLength(1) - 1;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    colB = 0;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                            else
                            {
                                colB = 0;
                                if (pond[rowB, colB] == 'F')
                                {
                                    pond[rowB, colB] = '-';
                                    colB = pond.GetLength(1) - 1;
                                }
                                else if (char.IsLower(pond[rowB, colB]))
                                {
                                    woodbranches.Push(pond[rowB, colB]);
                                }
                                pond[rowB, colB] = 'B';
                            }
                        }
                    }
                }
            }

            int c = 0;
            for (int rows = 0; rows < pond.GetLength(0); rows++)
            {
                for (int cols = 0; cols < pond.GetLength(1); cols++)
                {
                    if (char.IsLower(pond[rows, cols]))
                    {
                        c++;
                    }
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"The Beaver successfully collect {woodbranches.Count} wood branches: {string.Join(", ", woodbranches.Reverse())}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {c} branches left");
            }

            for (int rows = 0; rows < pond.GetLength(0); rows++)
            {
                for (int cols = 0; cols < pond.GetLength(1); cols++)
                {
                    if (rows == pond.GetLength(0) - 1 && cols == pond.GetLength(1) - 1)
                    {
                        Console.Write($"{pond[rows, cols]}");
                    }
                    Console.Write($"{pond[rows,cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
