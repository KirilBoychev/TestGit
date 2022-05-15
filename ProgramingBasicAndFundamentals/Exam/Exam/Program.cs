using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            const double nightPrize = 20.0;
            const double trasportCardPrize = 1.6;
            const double museumPrize = 6.0;

            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            double allNightsPrize = nightPrize * nights;
            double allSardsPrize = trasportCardPrize * transportCards;
            double allMuseumPrize = museumPrize * museumTickets;
            double sum = (allMuseumPrize + allNightsPrize + allSardsPrize) * people;

            sum *= 1.25;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
