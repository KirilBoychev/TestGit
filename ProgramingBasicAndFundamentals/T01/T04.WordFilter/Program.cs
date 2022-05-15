using System;
using System.Linq;

namespace T04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var indexValue in inputWords)
            {
                Console.WriteLine(indexValue);
            }
            //for (int index = 0; index < inputWords.Length; index++)
            //{
            //    if (inputWords[index].Length % 2 == 0)
            //    {
            //        Console.WriteLine($"{inputWords[index]}");
            //    }
            //}
        }
    }
}
