using System;
using System.Linq;

namespace T02.Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte arrayLenght = byte.Parse(Console.ReadLine());

            //int[] arr = new int[arrayLenght];
            //int sum = 0;

            //for (int rows = 0; rows < arr.Length; rows++)
            //{
            //    int[] nestedArr = new int[rows + 1];


            //    for (int index = 0; index <= rows; index++)
            //    {
            //        nestedArr[index] = sum;

            //        if (index == 0)
            //        {
            //            nestedArr[0] = arr[0] = 1;
            //            //Console.Write($"{nestedArr[0]} ");
            //        }
            //        else if (index == nestedArr.Length - 1)
            //        {
            //            nestedArr[rows] = 1;
            //            //Console.Write($"{nestedArr[rows]}");
            //        }
            //        else
            //        {
            //            //Console.Write($"{sum} ");
            //            sum = 0;
            //            sum = nestedArr[index - 1] + nestedArr[index];
            //        }
            //    }
            //    Console.WriteLine(String.Join(' ', arr[rows]));
            //}
            byte lenght = byte.Parse(Console.ReadLine());

            int[][] arr = new int[lenght][];

            for (int row = 0; row < lenght; row++)
            {
                arr[row] = new int[row + 1];
                arr[row][0] = 1;
                arr[row][^1] = 1;
                for (int col = 1; col < row; col++)
                {
                    arr[row][col] = arr[row - 1][col - 1] + arr[row - 1][col];
                }
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(String.Join(' ', arr[i]));
            }
        }
    }
}
