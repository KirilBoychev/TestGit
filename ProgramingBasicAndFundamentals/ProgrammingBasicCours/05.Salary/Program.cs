using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Facebook = 150.0;
            const double Instagram = 100.0;
            const double Reddit = 50.0;

            //INPUT FROM THE CONSOLE
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < openTabs; i++)
            {
                string nameOfWebsite = Console.ReadLine();
                switch (nameOfWebsite)
                {
                    case "Facebook":
                        salary -= Facebook;
                        break;
                    case "Instagram":
                        salary -= Instagram;
                        break;
                    case "Reddit":
                        salary -= Reddit;
                        break;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{Math.Round(salary)}");
            }
        }
    }
}
