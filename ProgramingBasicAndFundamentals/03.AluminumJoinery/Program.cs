using System;

namespace _03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDograma = int.Parse(Console.ReadLine());
            string typeOfDograma = Console.ReadLine();
            string delivery = Console.ReadLine();

            const double deliveryPrize = 60.0;
            double expenses = 0;

            if (countDograma <= 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {

 

            switch (typeOfDograma)
            {
                case "90X130":
                    expenses = 110 * countDograma;
                    if (countDograma > 30 && countDograma <= 60)
                    {
                        expenses *= 0.95;
                    }
                    if (countDograma > 60)
                    {
                        expenses *= 0.92;
                    }
                    break;
                case "100X150":
                    expenses = 140 * countDograma;
                    if (countDograma > 40 && countDograma <= 80)
                    {
                        expenses *= 0.94;
                    }
                    if (countDograma > 80)
                    {
                        expenses *= 0.9;
                    }
                    break;
                case "130X180":
                    expenses = 190 * countDograma;
                    if (countDograma > 20 && countDograma <= 50)
                    {
                        expenses *= 0.93;
                    }
                    if (countDograma > 50)
                    {
                        expenses *= 0.88;
                    }
                    break;
                case "200X300":
                    expenses = 250 * countDograma;
                    if (countDograma > 25 && countDograma <= 50)
                    {
                        expenses *= 0.91;
                    }
                    if (countDograma > 50)
                    {
                        expenses *= 0.86;
                    }
                    break;
            }

            switch (delivery)
            {
                case "With delivery":
                    expenses += deliveryPrize;
                    break;
                
            }

            if (countDograma > 99)
            {
                expenses *= 0.96;
            }

            Console.WriteLine($"{expenses:f2} BGN");
            }
        }
    }
}
