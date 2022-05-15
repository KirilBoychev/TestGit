using System;

namespace _05.ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            const double toyPrize = 5.0;
            const double sweaterPrize = 15.0;

            int counterChildred = 0;
            int counterOld = 0;

            double sumToys = 0;
            double sumSweaters = 0;

            int number = int.Parse(Console.ReadLine());
            string row = number.ToString();

            

            while (row != "Christmas")
            {
                number = Int32.Parse(row);
                if (number <= 16)
                {
                    counterChildred++;
                    sumToys += toyPrize;
                }
                else
                {
                    counterOld++;
                    sumSweaters += sweaterPrize;
                }

                row = number.ToString();
                row = Console.ReadLine();
            }

            Console.WriteLine($"Number of adults: {counterOld}");
            Console.WriteLine($"Number of kids: {counterChildred}");
            Console.WriteLine($"Money for toys: {sumToys}");
            Console.WriteLine($"Money for sweaters: {sumSweaters}");
        }
    }
}
