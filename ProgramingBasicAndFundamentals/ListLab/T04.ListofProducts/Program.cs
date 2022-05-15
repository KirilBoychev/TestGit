using System;
using System.Collections.Generic;

namespace T04.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>(countOfProducts);
            string text = string.Empty;
            int counter = 0;

            for (int index = 0; index < countOfProducts; index++)
            {
                text = Console.ReadLine();
                products.Add(text);
            }

            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                counter++;
                Console.WriteLine($"{counter}.{products[i]}");
            }
        }
    }
}
