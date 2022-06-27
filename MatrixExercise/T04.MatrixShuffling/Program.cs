using System;
using System.Linq;

namespace T04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string com = commandArr[0];

                if (com != "swap" || commandArr.Length != 5)
                {
                    Console.WriteLine($"Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(commandArr[1]);
                    int col1 = int.Parse(commandArr[2]);
                    int row2 = int.Parse(commandArr[3]);
                    int col2 = int.Parse(commandArr[4]);
                    if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) &&
                        row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string oldOne = matrix[row1, col1];
                        string newOne = matrix[row2, col2];
                        matrix[row1, col1] = newOne;
                        matrix[row2, col2] = oldOne;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write("{0} ", matrix[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
            }
        }
    }
}
