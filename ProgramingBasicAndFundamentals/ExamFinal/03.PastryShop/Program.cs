using System;

namespace _03.PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string cakeName = Console.ReadLine();
            int countOrderdCakes = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            double expenses = 0.0;

            switch (cakeName)
            {
                case "Cake":
                    if (dayOfDecember <= 15)
                    {
                        expenses = 24.0 * countOrderdCakes;
                    }
                    else
                    {
                        expenses = 28.7 * countOrderdCakes;
                    }
                    break;
                case "Souffle":
                    if (dayOfDecember <= 15)
                    {
                        expenses = 6.66 * countOrderdCakes;
                    }
                    else
                    {
                        expenses = 9.8 * countOrderdCakes;
                    }
                    break;
                case "Baklava":
                    if (dayOfDecember <= 15)
                    {
                        expenses = 12.6 * countOrderdCakes;
                    }
                    else
                    {
                        expenses = 16.98 * countOrderdCakes;
                    }
                    break;
            }

            if (dayOfDecember <= 22)
            {
                if (expenses >= 100 && expenses <= 200)
                {
                    expenses *= 0.85;
                }

                if (expenses > 200)
                {
                    expenses *= 0.75;
                }

                if (dayOfDecember <= 15)
                {
                    expenses *= 0.9;
                }

            }

            Console.WriteLine($"{expenses:f2}");
        }
    }
}
