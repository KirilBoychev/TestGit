using System;
using System.Linq;

namespace T08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int inputSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] newArr = new int[2];

            for (int currentIndex = 0; currentIndex < inputArray.Length - 1; currentIndex++)
            {
                for (int i = currentIndex + 1; i < inputArray.Length; i++)
                {
                    sum = inputArray[currentIndex] + inputArray[i];
                    if (sum == inputSum)
                    {
                        newArr[0] = inputArray[currentIndex];
                        newArr[1] = inputArray[i];
                        Console.WriteLine(String.Join(' ', newArr));
                    }
                }
            }
        }
    }
}
