using System;
using System.Linq;

namespace T04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());

            
            for (int rotation = 1; rotation <= countOfRotations; rotation++)
            {
                int firstNum = arr[0];
                for (int index = 0; index <= arr.Length - 2; index++)
                {
                    arr[index] = arr[index + 1];
                }
                arr[arr.Length - 1] = firstNum;
            }
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
