using System;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Брой танцьори – цяло число в интервала[1 … 10]
            // 2.Брой точки – реално число в интервала[1.00 … 10000.00]
            //3.Сезон –  текст със следните възможности -"summer" или "winter"
            //4.Място – текст със следните възможности -"Bulgaria" или "Abroad"

            int dansersCount = int.Parse(Console.ReadLine());
            double point = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = Console.ReadLine();

            double sum = 0;

            switch (country)
            {
                case "Bulgaria": // point * count;
                    sum = dansersCount * point;
                    if (season == "summer")
                    {
                        sum *= 0.95;
                    }
                    else if (season == "winter")
                    {
                        sum *= 0.92;
                        Console.WriteLine(sum);
                    }
                    break;
                case "Abroad": // count * point * 1.5
                    sum = dansersCount * point * 1.5;
                    if (season == "summer")
                    {
                        sum *= 0.90;
                    }
                    else if (season == "winter")
                    {
                        sum *= 0.85;
                    }
                    break;
            }

            double sumCharity = 0;
            sumCharity = 0.75 * sum;

            double sumMemberOfGroup = (sum - sumCharity) / dansersCount;

            Console.WriteLine($"Charity - {sumCharity:f2}");
            Console.WriteLine($"Money per dancer - {sumMemberOfGroup:f2}");

        }
    }
}
