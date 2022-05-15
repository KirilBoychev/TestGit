using System;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            double printOnePagePrize = double.Parse(Console.ReadLine());
            double printOneCoverPrize = double.Parse(Console.ReadLine());
            int pecentReductionForPrinting = int.Parse(Console.ReadLine());
            double designerPrize = double.Parse(Console.ReadLine());
            int percentFromGrew = int.Parse(Console.ReadLine());

            double prizeAllPages = printOnePagePrize * 899;
            double prizeAllCovers = printOneCoverPrize * 2;
            double sum = prizeAllCovers + prizeAllPages;
            double afterReduce = sum - sum * (pecentReductionForPrinting / 100.0);
            double sum1 = afterReduce + designerPrize;
            sum1 = sum1 - sum1 * (percentFromGrew / 100.0);

            Console.WriteLine($"Avtonom should pay {sum1:f2} BGN.");
        }
    }
}
