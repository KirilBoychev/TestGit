using System;

namespace T02.PrintNumbersinReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfnumber = int.Parse(Console.ReadLine());

            int[] everynumber = new int[countOfnumber];
            for (int i = 0; i < everynumber.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                everynumber[i] = currentNum;
            }
            for (int j = everynumber.Length-1; j >= 0; j--)
            {
                Console.Write($"{everynumber[j]} ");
            }
        }
    }
}
