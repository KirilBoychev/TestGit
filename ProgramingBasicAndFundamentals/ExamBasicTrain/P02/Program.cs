using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            decimal priceSingleNight = decimal.Parse(Console.ReadLine());    
            int additionalExpense = int.Parse(Console.ReadLine());

            if (countNights <= 7)
            {
                budget -= priceSingleNight * countNights + (decimal)(additionalExpense / 100.0) * budget;
            }
            else
            {
                budget -= ((decimal)(0.95) * priceSingleNight) * countNights + (decimal)(additionalExpense / 100.0) * budget;
            }

            if (budget >= 0)
            {
                Console.WriteLine($"Ivanovi will be left with {budget:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget):f2} leva needed.");
            }
        }
    }
}
