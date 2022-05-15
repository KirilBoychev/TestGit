using System;
using System.Collections.Generic;

namespace T02.Aminertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourse;

            Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();

            while ((resourse = Console.ReadLine()) != "stop")
            {
                double quantity = int.Parse(Console.ReadLine());

                if (keyValuePairs.ContainsKey(resourse))
                {
                    keyValuePairs[resourse] += quantity;
                }
                else
                {
                    keyValuePairs.Add(resourse, quantity);
                }
            }

            foreach (var key in keyValuePairs)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}
