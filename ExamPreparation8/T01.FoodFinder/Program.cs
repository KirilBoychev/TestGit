using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T01.FoodFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> consonants = new Stack<char>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            List<string> list = new List<string>() { "pear", "flour", "pork", "olive" };
            List<string> list2 = new List<string>() { "pear", "flour", "pork", "olive" };

            while (vowels.Count > 0 && consonants.Count > 0)
            {
                char currVowel = vowels.Peek();
                char currConsonant = consonants.Peek();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Contains(currVowel))
                    {
                        for (int j = 0; j < list[i].Length; j++)
                        {
                            if (list[i][j] == currVowel)
                            {
                                list[i] = list[i].Remove(j, 1);
                                j--;
                            }
                        }
                    }
                    if (list[i].Contains(currConsonant))
                    {
                        for (int j = 0; j < list[i].Length; j++)
                        {
                            if (list[i][j] == currConsonant)
                            {
                                list[i] = list[i].Remove(j, 1);
                                j--;
                            }
                        }
                    }
                }

                vowels.Dequeue();
                vowels.Enqueue(currVowel);

                consonants.Pop();
            }

            List<string> final = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "")
                {
                    final.Add(list2[i]);
                }
            }

            Console.WriteLine($"Words found: {final.Count}");
            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
        }
    }
}
