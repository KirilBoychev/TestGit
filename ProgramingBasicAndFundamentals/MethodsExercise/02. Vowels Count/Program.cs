using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelCounts(input));
        }

        static int VowelCounts(string input)
        {
            input = input.ToLower();
            
            
            int counter = 0;
            foreach (var vowel in input)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
