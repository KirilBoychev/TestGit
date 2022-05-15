using System;
using System.Linq;

namespace T05.Top_ntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topInteger = new int[arr.Length];
            int indexForTopIntegers = 0;
            for (int indexInArr = 0; indexInArr < arr.Length; indexInArr++)
            {
                int currentNum = arr[indexInArr];
                bool isTopInteger = true;

                for (int i = indexInArr + 1; i < arr.Length; i++)
                {
                    if (currentNum <= arr[i])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topInteger[indexForTopIntegers] = currentNum;
                    indexForTopIntegers++;
                }
            }

            for (int j = 0; j < indexForTopIntegers; j++)
            {
                Console.Write($"{topInteger[j]} ");
            }
        }
    }
}
