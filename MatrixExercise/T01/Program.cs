using System;
using System.Linq;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            FillMatrix(matrix);

            int sum = 0;
            DiagonalsSum(matrix, sum);
        }

        static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }

        static void DiagonalsSum(int[,] matrix, int sum)
        {
            int sum1 = 0;
            for (int index = 0; index < matrix.GetLength(0); index++)
            {
                sum1 += matrix[index, index];
            }

            int sum2 = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum2 += matrix[row, matrix.GetLength(1) - 1 - row];
            }

            sum = Math.Abs(sum1 - sum2);
            Console.WriteLine(sum);
        }
    }
}
