using System;
using System.Linq;

namespace T02.TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] input1 = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    matrix[rows, cols] = input1[cols];
            }

            int sCount = 0;
            int wCount = 0;
            int bCount = 0;
            int boarCount = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop the hunt")
            {
                string[] inputArr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                int row = int.Parse(inputArr[1]);
                int col = int.Parse(inputArr[2]);

                if (command == "Collect")
                {
                    CollectPeter(matrix, row, col, ref sCount, ref wCount, ref bCount);
                }
                else if (command == "Wild_Boar")
                {
                    string direction = inputArr[3];
                    CollectWildBoar(matrix, row, col, ref boarCount, direction);
                }
            }

            Console.WriteLine($"Peter manages to harvest {bCount} black, {sCount} summer, and {wCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarCount} truffles.");

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (cols == matrix.GetLength(1) - 1)
                    {
                        Console.Write($"{matrix[rows, cols]}");
                        break;
                    }
                    Console.Write($"{matrix[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }

        static void CollectWildBoar(char[,] matrix, int row, int col, ref int boarCount, string direction)
        {
            if (direction == "up")
            {
                for (int i = row; i >= 0; i -= 2)
                {
                    if (matrix[i, col] == 'S' || matrix[i, col] == 'W' || matrix[i, col] == 'B')
                    {
                        boarCount++;
                        matrix[i, col] = '-';
                    }
                }
            }
            else if (direction == "down")
            {
                for (int i = row; i < matrix.GetLength(0); i += 2)
                {
                    if (matrix[i, col] == 'S' || matrix[i, col] == 'W' || matrix[i, col] == 'B')
                    {
                        boarCount++;
                        matrix[i, col] = '-';
                    }
                }
            }
            else if (direction == "right")
            {
                for (int i = col; i < matrix.GetLength(1); i += 2)
                {
                    if (matrix[row, i] == 'S' || matrix[row, i] == 'W' || matrix[row, i] == 'B')
                    {
                        boarCount++;
                        matrix[row, i] = '-';
                    }
                }
            }
            else if (direction == "left")
            {
                for (int i = col; i >= 0; i -= 2)
                {
                    if (matrix[row, i] == 'S' || matrix[row, i] == 'W' || matrix[row, i] == 'B')
                    {
                        boarCount++;
                        matrix[row, i] = '-';
                    }
                }
            }
        }

        static void CollectPeter(char[,] matrix, int row, int col, ref int sCount, ref int wCount, ref int bCount)
        {
            if (matrix[row,col] == 'S')
            {
                sCount++;
                matrix[row, col] = '-';
            }
            else if (matrix[row, col] == 'W')
            {
                wCount++;
                matrix[row, col] = '-';
            }
            else if (matrix[row, col] == 'B')
            {
                bCount++;
                matrix[row, col] = '-';
            }
        }
    }
}
