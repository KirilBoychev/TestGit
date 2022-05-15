using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> detonateNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int index = 0; index < allNumbers.Count; index++)
            {
                if (detonateNumbers[0] == allNumbers[index])
                {
                    int counter = 0;

                    for (int i = 1; i <= detonateNumbers[1]; i++)
                    {
                        if (index - i >= 0)
                        {
                            allNumbers.RemoveAt(index - i);
                            allNumbers.Insert(index - i, 0);
                            
                        }
                        if (index + i < allNumbers.Count)
                        {
                            allNumbers.Insert(index + i, 0);
                            allNumbers.RemoveAt(index + i + 1);
                        }
                    }
                    allNumbers.RemoveAt(index);
                    allNumbers.Insert(index, 0);
                }
            }
            
            int sum = 0;
            foreach (int number in allNumbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
