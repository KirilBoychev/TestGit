using System;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double bagPrize = double.Parse(Console.ReadLine());
            double bagKilos = double.Parse(Console.ReadLine());
            int daysBeforeJurney = int.Parse(Console.ReadLine());
            int countbags = int.Parse(Console.ReadLine());
            
            

            if (bagKilos < 10)
            {
                bagPrize = bagPrize * 0.2;
            }
            if (bagKilos >= 10 && bagKilos <=20)
            {
                bagPrize = bagPrize * 0.5;
            }
                        

            if (daysBeforeJurney > 30)
            {
                bagPrize *= 1.1;
            }
            else if (daysBeforeJurney >=7 && daysBeforeJurney <= 30)
            {
                bagPrize *= 1.15;
            }
            else if (daysBeforeJurney < 7)
            {
                bagPrize *= 1.4;
            }
            double sum = bagPrize * countbags;
            Console.WriteLine($" The total price of bags is: {sum:f2} lv. ");
        }
    }
}
