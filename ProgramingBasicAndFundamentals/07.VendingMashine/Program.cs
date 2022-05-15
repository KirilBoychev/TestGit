using System;

namespace _07.VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tenCoins = 0.1;
            const double twentyCoins = 0.2;
            const double fiftyCoins = 0.5;
            const double dollar = 1.0;
            const double twoDollars = 2.0;

            double sumMoney = 0;
            
            string text = Console.ReadLine();

            while (text != "Start")
            {
                double moneyInsert = Convert.ToDouble(text);
                if (moneyInsert == tenCoins || moneyInsert == twentyCoins || moneyInsert == fiftyCoins || moneyInsert == dollar || moneyInsert == twoDollars)
                {
                    sumMoney += moneyInsert;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyInsert}");
                }
                text = Convert.ToString(moneyInsert);
                text = Console.ReadLine();
            }

            while (text != "End")
            {
                switch (text)
                {
                    case "Nuts":
                        if (sumMoney >= 2.0)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sumMoney -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sumMoney >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            sumMoney -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sumMoney >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sumMoney -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sumMoney >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            sumMoney -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sumMoney >= 1.0)
                        {
                            Console.WriteLine($"Purchased coke");
                            sumMoney -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Start":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                text = Console.ReadLine();
            }
            
            if (text == "End")
            {
                Console.WriteLine($"Change: {sumMoney:f2}");
            }
            
        }
    }
}
