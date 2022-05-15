using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.SumAdjasentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            //int sum = 0;

            //List<double> newNum = new List<double>();


            for (int index = 0; index < number.Count; index++)
            {
                if (index + 1 < number.Count)
                {
                    if (number[index] == number[index + 1])
                    {
                        number[index] += number[index + 1];
                        number.RemoveAt(index + 1);
                        index = -1;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', number));
        }
    }
}
