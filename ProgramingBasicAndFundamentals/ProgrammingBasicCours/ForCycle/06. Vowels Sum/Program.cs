using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            const int a = 1;
            const int e = 2;
            const int i = 3;
            const int o = 4;
            const int u = 5;

            for (int letter = 0; letter < word.Length; letter++)
            {
                char lett = word[letter];
                if (lett == 'a')
                {
                    sum += 1;
                }
                else if (lett == 'e')
                {
                    sum += 2;
                }
                else if (lett == 'i')
                {
                    sum += 3;
                }
                else if (lett == 'o')
                {
                    sum += 4;
                }
                else if (lett == 'u')
                {
                    sum += 5;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
