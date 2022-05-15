using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countVideoCards = int.Parse(Console.ReadLine());
            int countprocesors = int.Parse(Console.ReadLine());
            int countram = int.Parse(Console.ReadLine());

            const double videoCard = 250; // lv/count
            double procesors = 0.35 * videoCard * countVideoCards; // lv/count
            double ram = 0.10 * videoCard * countVideoCards; // lv/count

            double sum = countVideoCards * videoCard + ram * countram + procesors * countprocesors;

            if (countVideoCards > countprocesors)
            {
                sum *= 0.85;
            }

            double difference = Math.Abs(sum - budget);
            if (budget >= sum)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}
