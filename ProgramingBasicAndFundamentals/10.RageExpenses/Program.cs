using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrize = double.Parse(Console.ReadLine());
            double mousePrize = double.Parse(Console.ReadLine());
            double keyboardPrize = double.Parse(Console.ReadLine());
            double displayPrize = double.Parse(Console.ReadLine());

            int headsetCrashes = lostGameCount / 2;
            int mouseCrashes = lostGameCount / 3;
            int keyboardGrashes = lostGameCount / 6;
            int displayCrashes = lostGameCount / 12;

            double expenses = 0;
            expenses = headsetPrize * headsetCrashes + mousePrize * mouseCrashes + keyboardPrize * keyboardGrashes + displayPrize * displayCrashes;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
