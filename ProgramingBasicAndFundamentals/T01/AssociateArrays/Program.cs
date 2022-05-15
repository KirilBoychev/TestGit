using System;
using System.Linq;
using System.Collections.Generic;

namespace AssociateArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> keyValuePairs = new SortedDictionary<double, int>();

            foreach (int currNumber in arr)
            {
                if (keyValuePairs.ContainsKey(currNumber))
                {   
                    keyValuePairs[currNumber]++;
                }
                else
                {
                    keyValuePairs.Add(currNumber, 1);
                }
            }

            foreach (var number in keyValuePairs)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
