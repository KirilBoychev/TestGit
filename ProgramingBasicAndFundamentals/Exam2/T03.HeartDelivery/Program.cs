using System;
using System.Linq;

namespace T03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] input = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(byte.Parse)
                .ToArray();

            string command = string.Empty;
            int counter = 0;
            int lastIndex = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] comArr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string jump = comArr[0];
                int index = int.Parse(comArr[1]);

                counter++;

                if (counter > 0)
                {
                    index = lastIndex + index;
                }

                if (index > input.Length - 1)
                {
                    index = 0;
                }

                if (input[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }
                
                input[index] -= 2;
                if (input[index] == 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }

                lastIndex = index;
            }

            Console.WriteLine($"Cupid's last position was {lastIndex}.");

            int sum = 0;

            foreach (var item in input)
            {
                sum += item;
            }

            int c = 0;

            foreach (var item in input.Where(x => x != 0))
            {
                c++;    
            }

            if (sum == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {c} places.");
            }
        }
    }
}
