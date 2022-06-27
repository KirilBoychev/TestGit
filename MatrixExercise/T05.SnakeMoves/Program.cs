using System;
using System.Linq;

namespace T05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputStairs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            int[,] matrix = new int[inputStairs[0], inputStairs[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    for (int index = 0; index < snake.Length; index++)
                    {
                        matrix[rows, cols] = snake[index];
                    }
                }
                if (rows % 2 == 1)
                {
                    for (int i = 0; i < matrix[rows, inputStairs[1]]; i++)
                    {

                    }
                }
            }
        }
    }
}
