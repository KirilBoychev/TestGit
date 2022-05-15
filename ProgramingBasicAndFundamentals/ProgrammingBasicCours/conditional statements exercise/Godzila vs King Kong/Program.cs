using System;

namespace Godzila_vs_King_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT FROM THE CONSOLE
            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double equipmentPrizeForStatist = double.Parse(Console.ReadLine());

            // •	Декорът за филма е на стойност 10 % от бюджета.
            // •	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            double decor = 0.1 * budget;
            double equipmentAll = countStatists * equipmentPrizeForStatist;
            
           
            if (countStatists > 150)
            {
                equipmentAll *= 0.9;
            }
            double expenses = equipmentAll + decor;
            if (expenses > budget)
            {
                double difference = expenses - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
            else
            {
                double difference = budget - expenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}
