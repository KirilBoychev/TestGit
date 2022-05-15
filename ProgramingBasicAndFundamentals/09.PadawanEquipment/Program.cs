using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfPadowans = int.Parse(Console.ReadLine());
            double lightsaberPrize = double.Parse(Console.ReadLine());
            double robePrize = double.Parse(Console.ReadLine());
            double beltPrize = double.Parse(Console.ReadLine());

            double expenses = 0;
            expenses += Math.Ceiling(countOfPadowans * 1.1) * lightsaberPrize + countOfPadowans * robePrize;
            if (countOfPadowans >= 6)
            {
                int n = countOfPadowans / 6;
                countOfPadowans -= n;
            }
            expenses += countOfPadowans * beltPrize;

            double difference = Math.Abs(budget-expenses);

            if (budget >= expenses)
            {
                Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {difference:f2}lv more.");
            }
        }
    }
}
