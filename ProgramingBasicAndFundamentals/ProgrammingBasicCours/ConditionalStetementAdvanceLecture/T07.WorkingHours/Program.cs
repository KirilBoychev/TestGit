using System;

namespace T07
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            //работното време на офисът е от 10 - 18 часа, от понеделник до събота включително
            if (hour >= 10 && hour <= 18)
            {
                if (day == "Monday" && day == "Tuesday" && day == "Wednesday" && day == "Thursday" && day == "Friday" && day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
