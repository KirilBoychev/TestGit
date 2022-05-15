using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int countEvaluators = int.Parse(Console.ReadLine());
            double sum = pointsFromAcademy;

            for (int i = 0; i < countEvaluators; i++)
            {
                string nameOfEvaluator = Console.ReadLine();
                double pointsFromOneEvaluator = double.Parse(Console.ReadLine());
                sum += nameOfEvaluator.Length * pointsFromOneEvaluator / 2;
                if (sum > 1250.5)
                {
                    break;
                }
            }

            double difference = Math.Abs(1250.5 - sum); 
            if (sum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {difference:f1} more!");
            }
        }
    }
}
