using System;

namespace T01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double FoodForPigADay = 300.0;

            double foodQuantity = double.Parse(Console.ReadLine()); //for 30 days
            double hayQuantity = double.Parse(Console.ReadLine());  //for 30 days
            double coverQuantity = double.Parse(Console.ReadLine());//for 30 days
            double weightPig = double.Parse(Console.ReadLine());

            foodQuantity *= 1000.0;
            hayQuantity *= 1000.0;
            coverQuantity *= 1000.0;
            weightPig *= 1000.0;

            double foodForOneDay = foodQuantity / 30.0; // we have
            double neededHay = 0;
            double neededCover = weightPig / 3.0;

            if (foodForOneDay < FoodForPigADay)
            {
                Console.WriteLine("Merry must go to the pet store!");
                return;
            }

            for (int i = 1; i <= 30; i++)
            {
                foodQuantity -= FoodForPigADay;
                if (foodQuantity <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }

                if (i % 2 == 0)
                {
                    neededHay = foodQuantity * 0.05;
                    hayQuantity -= neededHay;
                }

                if (i % 3 == 0)
                {
                    coverQuantity -= neededCover;
                }
            }

            if (foodQuantity >= 0 && hayQuantity >= 0 && coverQuantity >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodQuantity/1000.0):f2}, Hay: {(hayQuantity/1000.0):f2}, Cover: {(coverQuantity/1000.0):f2}.");
                //Console.WriteLine($"{(foodQuantity/1000.0):f2}, Hay: {(hayQuantity/1000.0):f2}, Cover: {(coverQuantity/1000.0):f2}.");
            }
            else 
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}
