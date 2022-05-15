using System;

namespace SwimmingWorldReccord
{
    class Program
    {
        static void Main(string[] args)
        {
            double reccordSeconds = double.Parse(Console.ReadLine()); //sec
            double distanceInMeters = double.Parse(Console.ReadLine()); //m
            double timeSecondsForOneMeter = double.Parse(Console.ReadLine()); //sek for 1 meter

            // съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди
            // Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата,
            // резултатът трябва да се закръгли надолу до най-близкото цяло число

            double timeIvan = timeSecondsForOneMeter  * distanceInMeters; //sek

            const double additionalTime = 12.50;
            const double moreMeters = 15.00;
            if (distanceInMeters >=15)
            {
                double resultTime = Math.Floor(distanceInMeters / moreMeters) * additionalTime;
                timeIvan += resultTime;
            }
            
            

            
            if (timeIvan < reccordSeconds)
            {
                double difference = timeIvan - reccordSeconds;
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(timeIvan):f2} seconds.");
            }
            else
            {
                double difference = reccordSeconds - timeIvan;
                Console.WriteLine($"No, he failed! He was {Math.Abs(difference):f2} seconds slower.");
            }
        }
    }
}
