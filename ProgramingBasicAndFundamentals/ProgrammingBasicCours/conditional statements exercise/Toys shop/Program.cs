using System;

namespace Toys_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excurzionPrize = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            int countToys = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double totalPrize = puzzleCount * 2.6 + dollCount * 3 + bearCount * 4.1 + minionCount * 8.2 + truckCount * 2;
            
            if (countToys >= 50)
            {
                totalPrize *= 0.75;
            }

            totalPrize *= 0.9;

            double difference = 0;
            if (excurzionPrize > totalPrize)
            {
                difference = excurzionPrize - totalPrize;
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
            else
            {
                difference = totalPrize - excurzionPrize;
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
        }
    }
}
