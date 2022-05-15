using System;

namespace _02.BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            const double beerPrize = 1.2;

            string nameOfFootballFen = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int countBeerBottles = int.Parse(Console.ReadLine());
            int countChipsPackets = int.Parse(Console.ReadLine());

            double expenses1 = countBeerBottles * beerPrize;
            double expenses2 = (countBeerBottles * beerPrize * 0.45) * countChipsPackets;
            expenses2 = Math.Ceiling(expenses2);
            double sum = expenses1 + expenses2;

            double difference = Math.Abs(sum - budget);
            if (sum > budget)
            {
                Console.WriteLine($"{nameOfFootballFen} needs {difference:f2} more leva!");
            }
            else
            {
                Console.WriteLine($"{nameOfFootballFen} bought a snack and has {difference:f2} leva left.");
            }
        }
    }
}
