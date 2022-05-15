using System;

namespace P06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            double sum = 0;
            string wordPowerful = string.Empty;
            while ((word = Console.ReadLine()) != "End of words")
            {
                double currSum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    currSum += word[i];
                }
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u' || word[0] == 'y' ||
                    word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U' || word[0] == 'Y')
                {
                    currSum *= word.Length;
                }
                else
                {
                    currSum = Math.Round(currSum / word.Length);
                }
                if (currSum >= sum)
                {
                    sum = currSum;
                    wordPowerful = word;
                }
            }

            Console.WriteLine($"The most powerful word is {wordPowerful} - {sum}");
        }
    }
}
