﻿using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double prize = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    if (age >=0 && age <= 18)
                    {
                        Console.WriteLine($"{12}$"); ;
                    }
                    else if (age >18 && age <= 64)
                    {
                        Console.WriteLine($"{18}$"); ;

                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{12}$"); ;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine($"{15}$"); ;

                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine($"{20}$"); ;

                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{12}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        Console.WriteLine($"{5}$"); ;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine($"{12}$"); ;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        Console.WriteLine($"{10}$"); ;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
