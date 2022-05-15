using System;

namespace T04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const double springPrize = 3000.0;
            const double summerAndAutumnPrize = 4200.0;
            const double winterPrize = 2600.0;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countMen = int.Parse(Console.ReadLine());
            
            double sum = 0;

            if (countMen <= 6)
            {
                switch (season)
                {
                    case "Spring":
                        sum = springPrize * 0.9;
                        break;
                    case "Summer":
                        sum = summerAndAutumnPrize * 0.9;
                        break;
                    case "Autumn":
                        sum = summerAndAutumnPrize * 0.9;
                        break;
                    case "Winter":
                        sum = winterPrize * 0.9;
                        break;
                }
            }
            else if (countMen > 6 && countMen <= 11)
            {
                switch (season)
                {
                    case "Spring":
                        sum = springPrize * 0.85;
                        break;
                    case "Summer":
                        sum = summerAndAutumnPrize * 0.85;
                        break;
                    case "Autumn":
                        sum = summerAndAutumnPrize * 0.85;
                        break;
                    case "Winter":
                        sum = winterPrize * 0.85;
                        break;
                }
            }
            else if (countMen > 11)
            {
                switch (season)
                {
                    case "Spring":
                        sum = springPrize * 0.75;
                        break;
                    case "Summer":
                        sum = summerAndAutumnPrize * 0.75;
                        break;
                    case "Autumn":
                        sum = summerAndAutumnPrize * 0.75;
                        break;
                    case "Winter":
                        sum = winterPrize * 0.75;
                        break;
                }
            }

            if (countMen % 2 == 0)
            {
                if (season == "Autumn")
                    sum = sum;
                else
                {
                    sum *= 0.95;
                }
            }
            else
            {
                sum = sum;
            }

            double difference = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
