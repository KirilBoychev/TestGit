using System;

namespace Lunchbreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int periodSerial = int.Parse(Console.ReadLine());
            int periodBreak = int.Parse(Console.ReadLine());

            //Вашата задача е да напишете програма, с която ще разберете дали имате достатъчно време да изгледате епизода.
            //По време на почивката отделяте време за обяд и време за отдих. Времето за обяд ще бъде 1 / 8 от времето за почивка,
            //а времето за отдих ще бъде 1 / 4 от времето за почивка.
            double periodLunch = Convert.ToDouble(periodBreak) / 8;
            double periodFreeAir = Convert.ToDouble(periodBreak) / 4;
            double time = periodBreak - periodLunch - periodFreeAir;
            double difference = Math.Abs(time - periodSerial);
            
            if (time >= periodSerial)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
