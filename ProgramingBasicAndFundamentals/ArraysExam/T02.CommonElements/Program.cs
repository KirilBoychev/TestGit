using System;
using System.Linq;

namespace T02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();

            string[] arr1 = text1
                .Split();
            string[] arr2 = text2
                .Split();

            for (int index = 0; index < arr2.Length; index++)
            {
                for (int index2 = 0; index2 < arr1.Length; index2++)
                {
                    if (arr2[index] == arr1[index2])
                    {
                        Console.Write($"{arr2[index]} ");
                    }
                }
            }
        }
    }
}
