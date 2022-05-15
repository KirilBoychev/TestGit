using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            const double outFall4 = 39.99;
            const double CSOG = 15.99;
            const double ZplinterZell = 19.99;
            const double Honored2 = 59.99;
            const double RoverWatch = 29.99;
            const double RoverWatchOriginsEdition = 39.99;
           
            string gameName = Console.ReadLine();
            double firstBudget = budget;
            bool flag = true;

            while (gameName != "Game Time")
            {
                switch (gameName)
                {
                    case "OutFall 4":
                        budget -= outFall4;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += outFall4;
                        }
                        break;
                    case "CS: OG":
                        budget -= CSOG;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought CS: OG");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += CSOG;
                        }
                        break;
                    case "Zplinter Zell":
                        budget -= ZplinterZell;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += ZplinterZell;
                        }
                        break;
                    case "Honored 2":
                        budget -= Honored2;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought Honored 2");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += Honored2;
                        }
                        break;
                    case "RoverWatch":
                        budget -= RoverWatch;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += RoverWatch;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        budget -= RoverWatchOriginsEdition;
                        if (budget > 0)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                            budget += RoverWatchOriginsEdition;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                
                if (flag == false)
                {
                    break;
                }

                gameName = Console.ReadLine();
            }

            double difference = firstBudget - budget;

            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${difference:f2}. Remaining: ${budget:f2}");
            }
        }
    }
}
