﻿using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            while (Math.Abs(number) % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
            }
        }
    }
}
