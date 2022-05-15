using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroups = Console.ReadLine();
            string dayOFWeek = Console.ReadLine();

            double totalPrice = 0;
            switch (typeOfGroups)
            {
                case "Students":
                    if (dayOFWeek == "Friday")
                    {
                        totalPrice = countOfPeople * 8.45;
                    }
                    else if (dayOFWeek == "Saturday")
                    {
                        totalPrice = countOfPeople * 9.80;
                    }
                    else if (dayOFWeek == "Sunday")
                    {
                        totalPrice = countOfPeople * 10.46;
                    }
                    if (countOfPeople > 29)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                    }
                    if (dayOFWeek == "Friday")
                    {
                        totalPrice = countOfPeople * 10.9;
                    }
                    else if (dayOFWeek == "Saturday")
                    {
                        totalPrice = countOfPeople * 15.6;
                    }
                    else if (dayOFWeek == "Sunday")
                    {
                        totalPrice = countOfPeople * 16.0;
                    }
                    break;
                case "Regular":
                    if (dayOFWeek == "Friday")
                    {
                        totalPrice = countOfPeople * 15.0;
                    }
                    else if (dayOFWeek == "Saturday")
                    {
                        totalPrice = countOfPeople * 20.0;
                    }
                    else if (dayOFWeek == "Sunday")
                    {
                        totalPrice = countOfPeople * 22.5;
                    }
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
