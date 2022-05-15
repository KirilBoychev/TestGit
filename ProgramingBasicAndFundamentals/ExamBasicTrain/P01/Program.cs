using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double taxa = double.Parse(Console.ReadLine());
            double priceForShezlong = double.Parse(Console.ReadLine());
            double priceForUmbrella = double.Parse(Console.ReadLine());

            double sum = 0;
            sum += countPeople * taxa + Math.Ceiling(0.75 * countPeople) * priceForShezlong + Math.Ceiling(countPeople / 2.0) * priceForUmbrella;
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
