using System;

namespace T01.RandomizeWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random randomNumGenerator = new Random();

            int currNum = 0;

            for (int index = 0; index < words.Length; index++)
            {
                currNum = randomNumGenerator.Next(0, words.Length);

                string word = words[index];
                words[index] = words[currNum];
                words[currNum] = word;
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
