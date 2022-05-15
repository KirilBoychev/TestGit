using System;
using System.Linq;

namespace T02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeopleWaiting = int.Parse(Console.ReadLine());
            int[] currentStates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] vagosFullOfPeople = new int[currentStates.Length];
            int statesInCurrentVagon = 0;
            int lastCountOfPeople = 0;

            for (int index = 0; index < currentStates.Length; index++)
            {
                statesInCurrentVagon = 4 - currentStates[index];

                if (lastCountOfPeople >= 0)
                {
                    lastCountOfPeople = countOfPeopleWaiting;
                }
                else
                {
                    break;
                }
                countOfPeopleWaiting -= statesInCurrentVagon;

                if (countOfPeopleWaiting >= 0)
                {
                    vagosFullOfPeople[index] = 4;
                }
                else
                {
                    vagosFullOfPeople[index] = currentStates[index] + lastCountOfPeople;
                    break;
                }
            }

            if (countOfPeopleWaiting < 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', vagosFullOfPeople));
            }
            else if (countOfPeopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {countOfPeopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(' ', vagosFullOfPeople));
            }
            else if (countOfPeopleWaiting == 0)
            {
                Console.WriteLine(string.Join(' ', vagosFullOfPeople));
            }
        }
    }
}
