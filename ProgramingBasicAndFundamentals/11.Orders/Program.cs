using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrderes = int.Parse(Console.ReadLine());

            double sumForOneOrder = 0;
            double totalSum = 0;

            for (int everySingleOrder = 1; everySingleOrder <= countOfOrderes; everySingleOrder++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countOfCapsules = int.Parse(Console.ReadLine());

                sumForOneOrder = (days * countOfCapsules) * pricePerCapsule;
                totalSum += sumForOneOrder;
                Console.WriteLine($"The price for the coffee is: ${sumForOneOrder:f2}");
                sumForOneOrder = 0;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
