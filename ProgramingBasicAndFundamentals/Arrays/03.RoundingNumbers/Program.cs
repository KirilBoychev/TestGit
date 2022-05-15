using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"{array[index]} => {Math.Round(array[index], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
