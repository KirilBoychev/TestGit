using System;

namespace T12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfSells = double.Parse(Console.ReadLine());

            //Град    0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000  s > 10 000
            //Sofia   5 %               7 %                 8 %             12 %
            //Varna   4.5 %             7.5 %               10 %            13 %
            //Plovdiv 5.5 %             8 %                 12 %            14.5 %
            if (volumeOfSells >= 0 && volumeOfSells <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        double result = volumeOfSells * 0.05;
                        Console.WriteLine($"{result:f2}");
                        break;
                    case "Varna":
                        double result1 = volumeOfSells * 0.045;
                        Console.WriteLine($"{result1:f2}");
                        break;
                    case "Plovdiv":
                        double result2 = volumeOfSells * 0.055;
                        Console.WriteLine($"{result2:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (volumeOfSells > 500 && volumeOfSells <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        double result = volumeOfSells * 0.07;
                        Console.WriteLine($"{result:f2}");
                        break;
                    case "Varna":
                        double result1 = volumeOfSells * 0.075;
                        Console.WriteLine($"{result1:f2}");
                        break;
                    case "Plovdiv":
                        double result2 = volumeOfSells * 0.08;
                        Console.WriteLine($"{result2:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (volumeOfSells > 1000 && volumeOfSells <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        double result = volumeOfSells * 0.08;
                        Console.WriteLine($"{result:f2}");
                        break;
                    case "Varna":
                        double result1 = volumeOfSells * 0.10;
                        Console.WriteLine($"{result1:f2}");
                        break;
                    case "Plovdiv":
                        double result2 = volumeOfSells * 0.12;
                        Console.WriteLine($"{result2:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (volumeOfSells > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        double result = volumeOfSells * 0.12;
                        Console.WriteLine($"{result:f2}");
                        break;
                    case "Varna":
                        double result1 = volumeOfSells * 0.13;
                        Console.WriteLine($"{result1:f2}");
                        break;
                    case "Plovdiv":
                        double result2 = volumeOfSells * 0.145;
                        Console.WriteLine($"{result2:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
