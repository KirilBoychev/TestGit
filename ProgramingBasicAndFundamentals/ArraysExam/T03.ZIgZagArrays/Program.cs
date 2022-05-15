using System;
using System.Linq;

namespace T03.ZIgZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArrays = int.Parse(Console.ReadLine());

            int[] arr1 = new int[numberOfArrays];
            int[] arr2 = new int[numberOfArrays];
            for (int lines = 1; lines <= numberOfArrays; lines++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                if (lines % 2 == 0)
                {
                    arr1[lines-1] = currentArray[1];
                    arr2[lines-1] = currentArray[0];
                }
                else
                {
                    arr1[lines-1] = currentArray[0];
                    arr2[lines-1] = currentArray[1];
                }
            }
            Console.WriteLine(String.Join(' ', arr1));
            Console.WriteLine(String.Join(' ', arr2));
        }
    }
}
