using System;

namespace Plodove
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricest = double.Parse(Console.ReadLine());
            double bn = double.Parse(Console.ReadLine());
            double or = double.Parse(Console.ReadLine());
            double ml = double.Parse(Console.ReadLine());
            double st = double.Parse(Console.ReadLine());
            double sum = st * pricest + ml * pricest / 2 + or * pricest / 2 * (1 - 0.4) + bn * pricest / 2 * (1 - 0.8);
            Console.WriteLine(sum);
        }
    }
}
