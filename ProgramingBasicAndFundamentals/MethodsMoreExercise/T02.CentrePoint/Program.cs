using System;

namespace T02.CentrePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double xNew = 0;
            double yNew = 0;
            double minNum = double.MaxValue;

            for (int i = 0; i < 2; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

                if (minNum > ClosePoint(x, y))
                {
                    minNum = ClosePoint(x, y);
                    xNew = x;
                    yNew = y;
                }
            }

            Console.WriteLine($"({xNew}, {yNew})");
        }

        static double ClosePoint(double x, double y)
        {
            double currentPoint = Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2);
            currentPoint = Math.Sqrt(currentPoint);
            return currentPoint;
        }
    }
}
