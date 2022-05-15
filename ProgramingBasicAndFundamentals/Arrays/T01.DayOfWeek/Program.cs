using System;

namespace T01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] Array = new string[7]; 
            Array[0] = "Monday";
            Array[1] = "Tuesday";
            Array[2] = "Wednesday";
            Array[3] = "Thursday";
            Array[4] = "Friday";
            Array[5] = "Saturday";
            Array[6] = "Sunday";
            
            if (number > 0 && number < 8)
            {
                Console.WriteLine(Array[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
