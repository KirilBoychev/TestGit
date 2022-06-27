using System;
using System.Linq;

namespace T02.PawnWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];

            int rW = 0;
            int cW = 0;
            int rB = 0;
            int cB = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'w')
                    {
                        rW = rows;
                        cW = cols;
                    }
                    if (matrix[rows, cols] == 'b')
                    {
                        rB = rows;
                        cB = cols;
                    }
                }
            }

            char[,] matrix2 = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                int currRow = i + 1;
                string row = "abcdefgh";
                for (int j = 0; j < 8; j++)
                {
                    matrix2[i, j] = row[j];
                } 
            }

            int currentRow = 0;
            int currentCol = 0;

            while (rW != 0 && rB != matrix.GetLength(0) - 1)
            {
                if (cW - 1 > -1 && cW + 1 < 8)
                {
                    if (matrix[rW - 1, cW - 1] == 'b')
                    {
                        matrix[rW, cW] = '-';
                        rW--;
                        cW--;
                        matrix[rW, cW] = 'w';
                        //for (int i = 0; i < 8; i++)
                        //{
                        //    for (int j = 0; j < 8; j++)
                        //    {
                        //        if (rW == i && cW == j)
                        //        {
                        //            currentRow = i - 1;
                        //            currentCol = j;
                        //        }
                        //    }
                        //}
                        Console.WriteLine($"Game over! White capture on {matrix2[rW, cW]}{8 - rW}.");
                        break;
                    }
                    else if (matrix[rW - 1, cW + 1] == 'b')
                    {
                        matrix[rW, cW] = '-';
                        rW--;
                        cW++;
                        matrix[rW, cW] = 'w';
                        //for (int i = 0; i < 8; i++)
                        //{
                        //    for (int j = 0; j < 8; j++)
                        //    {
                        //        if (rW == i && cW == j)
                        //        {
                        //            currentRow = i - 1;
                        //            currentCol = j;
                        //        }
                        //    }
                        //}
                        Console.WriteLine($"Game over! White capture on {matrix2[rW, cW]}{8 - rW}.");
                        break;
                    }
                    else
                    {
                        matrix[rW, cW] = '-';
                        rW--;
                        matrix[rW, cW] = 'w';
                    }
                }
                else
                {
                    matrix[rW, cW] = '-';
                    rW--;
                    matrix[rW, cW] = 'w';
                }

                if (rW == 0)
                {
                    break;
                }

                if (cB - 1 > -1 && cB + 1 < 8)
                {
                    if (matrix[rB + 1, cB - 1] == 'w')
                    {
                        matrix[rB, cB] = '-';
                        rB++;
                        cB--;
                        matrix[rB, cB] = 'b';
                        //for (int i = 0; i < 8; i++)
                        //{
                        //    for (int j = 0; j < 8; j++)
                        //    {
                        //        if (rB == i && cB == j)
                        //        {
                        //            currentRow = i - 1;
                        //            currentCol = j;
                        //        }
                        //    }
                        //}
                        Console.WriteLine($"Game over! Black capture on {matrix2[rB, cB]}{8 - rB}.");
                        break;
                    }
                    else if (matrix[rB + 1, cB + 1] == 'w')
                    {
                        matrix[rB, cB] = '-';
                        rB++;
                        cB++;
                        matrix[rB, cB] = 'b';
                        //for (int i = 0; i < 8; i++)
                        //{
                        //    for (int j = 0; j < 8; j++)
                        //    {
                        //        if (rB == i && cB == j)
                        //        {
                        //            currentRow = i - 1;
                        //            currentCol = j;
                        //        }
                        //    }
                        //}
                        Console.WriteLine($"Game over! Black capture on {matrix2[rB, cB]}{8- rB}.");
                        break;
                    }
                    else
                    {
                        matrix[rB, cB] = '-';
                        rB++;
                        matrix[rB, cB] = 'b';
                    }
                }
                else
                {
                    matrix[rB, cB] = '-';
                    rB++;
                    matrix[rB, cB] = 'b';
                }
            }

            if (rW == 0)
            {
                //for (int i = 0; i < 8; i++)
                //{
                //    for (int j = 0; j < 8; j++)
                //    {
                //        if (cW == j)
                //        {
                //            currentRow = 0;
                //            currentCol = j;
                //        }
                //    }
                //}
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {matrix2[rW, cW]}{8 - rW}.");
            }

            if (rB == matrix.GetLength(0) - 1)
            {
                //for (int i = 0; i < 8; i++)
                //{
                //    for (int j = 0; j < 8; j++)
                //    {
                //        if (cB == j)
                //        {
                //            currentRow = matrix.GetLength(0) - 1;
                //            currentCol = j;
                //        }
                //    }
                //}
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {matrix2[rB, cB]}{8 - rB}.");
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
