using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> deck2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum1 = 0;
            int sum2 = 0;
            for (int index = 0; index < Math.Max(deck1.Count, deck2.Count); index++)
            {
                sum1 = 0;
                sum2 = 0;
                for (int i = 0; i < deck1.Count; i++)
                {
                    sum1 += deck1[i];
                }
                if (sum1 == 0)
                {
                    break;
                }

                for (int i = 0; i < deck2.Count; i++)
                {
                    sum2 += deck2[i];
                }
                if (sum2 == 0)
                {
                    break;
                }

                if (deck1[index] > deck2[index])
                {
                    deck1.Add(deck2[index]);
                    deck1.Add(deck1[index]);
                    deck1[index] = 0;
                    deck2[index] = 0;
                }
                else if (deck1[index] < deck2[index])
                {
                    deck2.Add(deck1[index]);
                    deck2.Add(deck2[index]);
                    deck1[index] = 0;
                    deck2[index] = 0;
                }
                else if (deck1[index] == deck2[index])
                {
                    deck1[index] = 0;
                    deck2[index] = 0;
                }
            }

            if (sum1 == 0)
            {
                sum2 = 0;
                for (int i = 0; i < deck2.Count; i++)
                {
                    sum2 += deck2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }
            if (sum2 == 0)
            {
                sum1 = 0;
                for (int i = 0; i < deck1.Count; i++)
                {
                    sum1 += deck1[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum1}");
            }
        }
    }
}
