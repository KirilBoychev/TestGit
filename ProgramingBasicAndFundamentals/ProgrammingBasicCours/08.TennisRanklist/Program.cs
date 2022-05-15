using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int W = 2000;
            const int F = 1200;
            const int SF = 720;

            int countTournirs = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            
            int pointsWinner = 0;
            int pointsFinal = 0;
            int pointsSemiFinal = 0;
            double percentWinner = 0.0;

            for (int i = 0; i < countTournirs; i++)
            {
                string nameOfTournir = Console.ReadLine();
                switch (nameOfTournir)
                {
                    case "W":
                        pointsWinner += W;
                        percentWinner += 1;
                        break;
                    case "F":
                        pointsFinal += F;
                        break;
                    case "SF":
                        pointsSemiFinal += SF;
                        break;
                }
            }

            int sum = pointsWinner + pointsFinal + pointsSemiFinal + startPoints;
            int sumWithoutStartPoints = pointsWinner + pointsFinal + pointsSemiFinal;
            double avaragePoints = sumWithoutStartPoints / countTournirs;
            percentWinner = percentWinner * 100.0 / countTournirs;

            Console.WriteLine($"Final points: {sum}");
            Console.WriteLine($"Average points: {Math.Round(avaragePoints)}");
            Console.WriteLine($"{percentWinner:f2}%");

        }
    }
}
