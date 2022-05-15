using System;

namespace _04.Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometersFirstDay = double.Parse(Console.ReadLine());

            double allKilometers = 0.0;
            allKilometers += kilometersFirstDay;
            double sum = 0;
            sum += kilometersFirstDay;
           
            for (int i = 0; i < days; i++)
            {
                int percentIncreasing = int.Parse(Console.ReadLine());

                allKilometers = allKilometers + allKilometers * (percentIncreasing / 100.0);

                sum += allKilometers;
            }
            
            if (sum >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sum - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - sum)} more kilometers");
            }
        }
    }
}
