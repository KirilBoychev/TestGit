using System;
using System.Linq;

namespace T06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            bool flag = false;

            for (int currentIndex = 0; currentIndex < arrayInput.Length; currentIndex++)
            {
                for (int leftIndex = 0; leftIndex < currentIndex; leftIndex++)
                {
                    sumLeft += arrayInput[leftIndex];
                }

                for (int rightIndex = currentIndex + 1; rightIndex <= arrayInput.Length - 1; rightIndex++)
                {
                    sumRight += arrayInput[rightIndex];
                }

                if (currentIndex == 0)
                {
                    sumLeft = 0;
                }
                if (currentIndex == arrayInput.Length - 1)
                {
                    sumRight = 0;
                }
                if (sumLeft == sumRight)
                {
                    Console.Write($"{currentIndex} ");
                    flag = true;
                }
                if (currentIndex != arrayInput.Length - 1)
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
