using System;

namespace EVEREST
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = Console.ReadLine();
            int peak = 5364;
            int counter = 1;

            while ((yesNo != "END") && (peak < 8848) && (counter < 5))
            {

                switch (yesNo)
                {
                    case "Yes":
                        counter++;
                        int meters = int.Parse(Console.ReadLine());
                        peak += meters;
                        break;
                    case "No":
                        meters = int.Parse(Console.ReadLine());
                        peak += meters;
                        break;
                }
                if ((peak < 8848) && (counter < 5))
                {
                    yesNo = Console.ReadLine();
                }
            }
            if ((peak >= 8848) && (counter <  5))
            {
                Console.WriteLine($"Goal reached for {counter} days!");
            }
            if ((yesNo == "END") || (counter >= 5))
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{peak}");
            }
        }
    }
}
