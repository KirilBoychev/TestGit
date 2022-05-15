using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBalls = int.Parse(Console.ReadLine());

            double points = 0;
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterBlack = 0;
            int counterOtherColor = 0;

            for (int i = 0; i < countOfBalls; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        points += 5;
                        counterRed++;
                        break;
                    case "orange":
                        points += 10;
                        counterOrange++;
                        break;
                    case "yellow":
                        points += 15;
                        counterYellow++;
                        break;
                    case "white":
                        points += 20;
                        counterWhite++;
                        break;
                    case "black":
                        points *= 0.5;
                        points = Math.Floor(points);
                        counterBlack++;
                        break;
                    default:
                        counterOtherColor++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {counterRed}");
            Console.WriteLine($"Orange balls: {counterOrange}");
            Console.WriteLine($"Yellow balls: {counterYellow}");
            Console.WriteLine($"White balls: {counterWhite}");
            Console.WriteLine($"Other colors picked: {counterOtherColor}");
            Console.WriteLine($"Divides from black balls: {counterBlack}");
        }
    }
}
