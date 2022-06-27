using System;
using System.Linq;

namespace T02.SuperMario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());

            int rowsJaggedArray = int.Parse(Console.ReadLine());

            char[][] jaggedArr = new char[rowsJaggedArray][];

            int rowPrinces = 0;
            int colPrinces = 0;
            int rowMario = 0;
            int colMario = 0;

            for (int rows = 0; rows < rowsJaggedArray; rows++)
            {
                string input = Console.ReadLine();
                jaggedArr[rows] = new char[input.Length];
                for (int cols = 0; cols < input.Length; cols++)
                {
                    jaggedArr[rows][cols] = input[cols];
                    if (jaggedArr[rows][cols] == 'P')
                    {
                        rowPrinces = rows;
                        colPrinces = cols;
                    }
                    else if (jaggedArr[rows][cols] == 'M')
                    {
                        rowMario = rows;
                        colMario = cols;
                    }
                }
            }

            while (marioLives > 0)
            {
                if (rowMario == rowPrinces && colMario == colPrinces)
                {
                    jaggedArr[rowMario][colMario] = '-';
                    break;
                }

                char[] commandArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                char command = commandArr[0];
                int currRow = commandArr[1] - '0';
                int currCol = commandArr[2] - '0';

                if (command == 'W')
                {
                    jaggedArr[rowMario][colMario] = '-';
                    rowMario--;
                    marioLives--;
                    jaggedArr[currRow][currCol] = 'B';
                    if (rowMario < 0)
                    {
                        rowMario++;
                    }
                    else
                    {
                        if (jaggedArr[rowMario][colMario] == 'B')
                        {
                            marioLives -= 2;
                            if (marioLives > 0)
                            {
                                jaggedArr[rowMario][colMario] = 'M';
                            }
                            else
                            {
                                jaggedArr[rowMario][colMario] = 'X';
                            }
                        }
                        else if (jaggedArr[rowMario][colMario] == '-')
                            jaggedArr[rowMario][colMario] = 'M';
                    }
                }
                if (command == 'S')
                {
                    jaggedArr[rowMario][colMario] = '-';
                    rowMario++;
                    marioLives--;
                    jaggedArr[currRow][currCol] = 'B';
                    if (rowMario > rowsJaggedArray - 1)
                    {
                        rowMario--;
                    }
                    else
                    {
                        if (jaggedArr[rowMario][colMario] == 'B')
                        {
                            marioLives -= 2;
                            if (marioLives > 0)
                            {
                                jaggedArr[rowMario][colMario] = 'M';
                            }
                            else
                            {
                                jaggedArr[rowMario][colMario] = 'X';
                            }
                        }
                        else if (jaggedArr[rowMario][colMario] == '-')
                            jaggedArr[rowMario][colMario] = 'M';
                    }
                }
                if (command == 'A')
                {
                    jaggedArr[rowMario][colMario] = '-';
                    colMario--;
                    marioLives--;
                    jaggedArr[currRow][currCol] = 'B';
                    if (colMario < 0)
                    {
                        colMario++;
                    }
                    else
                    {
                        if (jaggedArr[rowMario][colMario] == 'B')
                        {
                            marioLives -= 2;
                            if (marioLives > 0)
                            {
                                jaggedArr[rowMario][colMario] = 'M';
                            }
                            else
                            {
                                jaggedArr[rowMario][colMario] = 'X';
                            }
                        }
                        else if (jaggedArr[rowMario][colMario] == '-')
                            jaggedArr[rowMario][colMario] = 'M';
                    }
                }
                if (command == 'D')
                {
                    jaggedArr[rowMario][colMario] = '-';
                    colMario++;
                    marioLives--;
                    jaggedArr[currRow][currCol] = 'B';
                    if (colMario > jaggedArr[rowsJaggedArray].Length - 1)
                    {
                        colMario++;
                    }
                    else
                    {
                        if (jaggedArr[rowMario][colMario] == 'B')
                        {
                            marioLives -= 2;
                            if (marioLives > 0)
                            {
                                jaggedArr[rowMario][colMario] = 'M';
                            }
                            else
                            {
                                jaggedArr[rowMario][colMario] = 'X';
                            }
                        }
                        else if (jaggedArr[rowMario][colMario] == '-')
                            jaggedArr[rowMario][colMario] = 'M';
                    }
                }
            }

            if (marioLives <= 0)
            {
                Console.WriteLine($"Mario died at {rowMario};{colMario}.");
            }
            else
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
            }

            for (int rows = 0; rows < rowsJaggedArray; rows++)
            {
                for (int cols = 0; cols < jaggedArr[rows].Length; cols++)
                {
                    Console.Write(jaggedArr[rows][cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
