using System;
using System.Linq;

namespace T02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[lenghtOfMatrix[0], lenghtOfMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currOne = matrix[row, col];
                    if (currOne == matrix[row, col + 1] && currOne == matrix[row + 1, col + 1] && currOne == matrix[row + 1, col])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
