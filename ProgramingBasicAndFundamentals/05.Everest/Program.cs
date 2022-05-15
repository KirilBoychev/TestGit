using System;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int maxDays = 0;
            
            int counter = 1;
            int sum = 5364;
            

            string yesNo = Console.ReadLine();
           
           

            while (yesNo != "END")
            {
                int meters = int.Parse(Console.ReadLine());
                sum += meters;
                

                if (yesNo == "Yes")
                {
                    counter++;
                    if (counter > maxDays)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{sum}");

                        break;
                    }
                }
                
                if (yesNo == "No")
                {
                    
                    if (sum >= 8848)
                    {
                        Console.WriteLine($"Goal reached for {counter} days!");
                        break;
                    }
                }

                if (sum >= 8848)
                {
                    Console.WriteLine($"Goal reached for {counter} days!");
                    break;
                }


                yesNo = Console.ReadLine();
            }


            if (yesNo == "END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{sum}");

            }





        }
    }
}
