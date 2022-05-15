using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.RemoveNegativesandReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int index = 0; index < integerList.Count; index++)
            {
                if (integerList[index] < 0)
                {
                    integerList.Remove(integerList[index]);
                    index--;
                }
            }

            if (integerList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                integerList.Reverse();
                Console.WriteLine(string.Join(' ', integerList));
            }
        }
    }
}
