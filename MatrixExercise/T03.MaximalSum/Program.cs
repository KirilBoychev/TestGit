using System;
using System.Linq;

namespace T03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[input[0], input[1]];

            int maxValue = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = rowArr[col];
            }

            int[,] currMatrix = null;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] > maxValue)
                    {
                        maxValue = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        currMatrix = null;
                        currMatrix = new int[3, 3] {
                                { matrix[row, col], matrix[row, col + 1], matrix[row, col + 2] },
                                { matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                                { matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]},
                                };
                    }
                }
            }

            Console.WriteLine($"Sum = {maxValue}");
            for (int row = 0; row < currMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < currMatrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", currMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
