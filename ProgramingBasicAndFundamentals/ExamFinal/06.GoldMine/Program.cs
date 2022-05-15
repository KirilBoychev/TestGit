using System;

namespace _06.GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLocations = int.Parse(Console.ReadLine());

            double GoldPerDay = 0;
            double averageGold = 0;
            int counter = 1;

            while (counter <= countLocations)
            {
                int averageNorm = int.Parse(Console.ReadLine());
                int countDiggingDays = int.Parse(Console.ReadLine());

                for (int j = 1; j <= countDiggingDays; j++)
                {
                    double kilosEverySingleDay = double.Parse(Console.ReadLine());
                    GoldPerDay += kilosEverySingleDay;
                    if (j == countDiggingDays)
                    {
                        averageGold = GoldPerDay / countDiggingDays;
                        double difference = Math.Abs(averageGold - averageNorm);
                        if (averageGold >= averageNorm)
                        {
                            Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                        }
                        else
                        {
                            Console.WriteLine($"You need {difference:f2} gold.");
                        }
                        GoldPerDay = 0;
                    }
                }
                
                

                counter++;
            }
        }
    }
}
