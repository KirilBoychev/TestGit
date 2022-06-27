using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(input);

            Console.WriteLine($"{queue.Max()}");

            foreach (var item in input)
            {
                if (item <= quantityFood)
                {
                    queue.Dequeue();
                    quantityFood -= item;
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
        }
    }
}
