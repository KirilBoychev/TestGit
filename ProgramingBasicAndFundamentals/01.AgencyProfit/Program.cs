using System;

namespace _01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCompany = Console.ReadLine();
            int ticketsCountForOld = int.Parse(Console.ReadLine());
            int ticketsCountForChildred = int.Parse(Console.ReadLine());
            double ticketPrizeOld = double.Parse(Console.ReadLine());
            double taxForSurving = double.Parse(Console.ReadLine());

            double oldExpenses = (ticketPrizeOld + taxForSurving) * ticketsCountForOld;
            double childredExpenses = (ticketPrizeOld * 0.3 + taxForSurving) * ticketsCountForChildred;
            double profit = 0.2 * (oldExpenses + childredExpenses);
            Console.WriteLine($"The profit of your agency from {nameOfCompany} tickets is {profit:f2} lv.");
        }
    }
}
