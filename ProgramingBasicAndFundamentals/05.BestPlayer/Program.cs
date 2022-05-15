using System;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();
            int countOfGoals = 0;
            double maxGoals = double.MinValue;
            string nameee = "";

            while (nameOfPlayer != "END")
            {

                countOfGoals = int.Parse(Console.ReadLine());

                if (countOfGoals > maxGoals)
                {
                    maxGoals = countOfGoals;
                    nameee = nameOfPlayer;
                }

                

                if (countOfGoals >= 10)
                {
                    Console.WriteLine($"{nameOfPlayer} is the best player!");
                    if (countOfGoals >= 3)
                    {
                        Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
                    }
                    else
                    {
                        Console.WriteLine($"He has scored {maxGoals} goals.");
                    }
                    break;
                }

                nameOfPlayer = Console.ReadLine();

                if (nameOfPlayer == "END")
                {
                    Console.WriteLine($"{nameee} is the best player!");
                    if (countOfGoals >= 3)
                    {
                        Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
                    }
                    else
                    {
                        Console.WriteLine($"He has scored {maxGoals} goals.");
                    }

                }
            }

            


        }
    }
}
