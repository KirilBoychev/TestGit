using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int ageLili = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            // GENERAL
            double moneyForBirthday = 0.00;
            double Stypka = 0.00;
            double totalPriceForToy = 0.00;
            
            // LOGIC FOR SOLVING THE PROBLEM
            for (int everyBirthday = 1; everyBirthday <= ageLili; everyBirthday++)
            {
                if (everyBirthday % 2 == 0)
                {
                    Stypka += 10;
                    moneyForBirthday += Stypka - 1;
                }
                else
                {
                    totalPriceForToy += priceToy;
                }
            }
            double totalPriceEarn = moneyForBirthday + totalPriceForToy;

            double difference = Math.Abs(totalPriceEarn - priceLaundry);
            if (totalPriceEarn >= priceLaundry)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:f2}");
            }
        }
    }
}
