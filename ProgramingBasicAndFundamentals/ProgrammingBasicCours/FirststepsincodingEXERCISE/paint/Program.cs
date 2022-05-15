using System;

namespace paint
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());
            double sum = paint * 1.1 * 14.5 + (nilon + 2) * 1.5 + thinner * 5 + 0.4;
            double sum1 = sum * 0.3 * hoursWork;
            double sum2 = sum + sum1;
            Console.WriteLine(sum2);

        }
    }
}
