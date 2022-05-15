using System;

namespace T03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double xNewFirst = 0;
            double yNewFirst = 0;
            double minNumFirst = double.MaxValue;
            double xNewSecond = 0;
            double yNewSecond = 0;
            double minNumSecond = double.MaxValue;

            for (int i = 0; i < 4; i++)
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());

                if (i < 2)
                {
                    //if (minNumFirst > ClosePoint(x, y))
                    //{
                    //    minNumFirst = ClosePoint(x, y);
                    //    xNewFirst = x;
                    //    yNewFirst = y;
                    //}
                }

            }

            //PROBLEM SOLVING:
            // 1. Londer line
            // 2. Close Point
            // 3. Print (Close point, next point)
        }

        static double ClosePoint(double x, double y)
        {
            double currentPoint = Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2);
            currentPoint = Math.Sqrt(currentPoint);

            double xNew = 0;
            double yNew = 0;
            double minNum = double.MaxValue;

            if (minNum > currentPoint)
            {
                minNum = currentPoint;
                xNew = x;
                yNew = y;
            }
            return minNum;
            //Console.WriteLine($"({xNew}, {yNew})");
        }

        static double LongerLine(double x, double y)
        {
            double lineOne = 0;
            double lineTwo = 0;

            lineOne = Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2);
            currentPoint = Math.Sqrt(currentPoint);


        }
    }
}
