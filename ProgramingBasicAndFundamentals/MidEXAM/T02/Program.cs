using System;
using System.Collections.Generic;
using System.Linq;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carsList = Console.ReadLine()
                .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal totalSum = 0;
            for (int index = 0; index < carsList.Length; index++)
            {
                string[] everyCar = carsList[index]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                decimal sum = 0;
                
                switch (everyCar[0])
                {
                    case "family":
                        sum = 50;
                        sum -= (decimal)(int.Parse(everyCar[1]) * 5);
                        int moreMax = int.Parse(everyCar[2]) / 3000;
                        sum += (decimal)(moreMax * 12);
                        Console.WriteLine($"A {everyCar[0]} car will pay {sum:f2} euros in taxes.");
                        break;
                    case "heavyDuty":
                        sum =   80;
                        sum -= (decimal)(int.Parse(everyCar[1]) * 8);
                        int moreMax1 = int.Parse(everyCar[2]) / 9000;
                        sum += (decimal)(moreMax1 * 14);
                        Console.WriteLine($"A {everyCar[0]} car will pay {sum:f2} euros in taxes.");
                        break;
                    case "sports":
                        sum = 100;
                        sum -= (decimal)(int.Parse(everyCar[1]) * 9);
                        int moreMax2 = int.Parse(everyCar[2]) / 2000;
                        sum += (decimal)(moreMax2 * 18);
                        Console.WriteLine($"A {everyCar[0]} car will pay {sum:f2} euros in taxes.");
                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        break;
                }

                totalSum += sum;

                sum = 0;
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalSum:f2} euros in taxes.");
        }
    }
}
