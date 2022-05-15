using System;

namespace T05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //град / продукт  coffee water   beer sweets  peanuts
            //Sofia           0.50    0.80    1.20    1.45    1.60
            //Plovdiv         0.40    0.70    1.15    1.30    1.50
            //Varna           0.45    0.70    1.10    1.35    1.55
            
            switch (town)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        double totalCoffee = quantity * 0.5;
                        Console.WriteLine(totalCoffee);
                    }
                    else if (product == "water")
                    {
                        double totalWater = quantity * 0.8;
                        Console.WriteLine(totalWater);
                    }
                    else if (product == "beer")
                    {
                        double totalBeer = quantity * 1.2;
                        Console.WriteLine(totalBeer);
                    }
                    else if (product == "sweets")
                    {
                        double totalSweets = quantity * 1.45;
                        Console.WriteLine(totalSweets);
                    }
                    else if (product == "peanuts")
                    {
                        double totalPeanuts = quantity * 1.60;
                        Console.WriteLine(totalPeanuts);
                    }
                    break;
                
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        double totalCoffee = quantity * 0.4;
                        Console.WriteLine(totalCoffee);
                    }
                    else if (product == "water")
                    {
                        double totalWater = quantity * 0.7;
                        Console.WriteLine(totalWater);
                    }
                    else if (product == "beer")
                    {
                        double totalBeer = quantity * 1.15;
                        Console.WriteLine(totalBeer);
                    }
                    else if (product == "sweets")
                    {
                        double totalSweets = quantity * 1.30;
                        Console.WriteLine(totalSweets);
                    }
                    else if (product == "peanuts")
                    {
                        double totalPeanuts = quantity * 1.50;
                        Console.WriteLine(totalPeanuts);
                    }
                    break;

                case "Varna":
                    if (product == "coffee")
                    {
                        double totalCoffee = quantity * 0.45;
                        Console.WriteLine(totalCoffee);
                    }
                    else if (product == "water")
                    {
                        double totalWater = quantity * 0.7;
                        Console.WriteLine(totalWater);
                    }
                    else if (product == "beer")
                    {
                        double totalBeer = quantity * 1.1;
                        Console.WriteLine(totalBeer);
                    }
                    else if (product == "sweets")
                    {
                        double totalSweets = quantity * 1.35;
                        Console.WriteLine(totalSweets);
                    }
                    else if (product == "peanuts")
                    {
                        double totalPeanuts = quantity * 1.55;
                        Console.WriteLine(totalPeanuts);
                    }
                    break;
            }
        }
    }
}
