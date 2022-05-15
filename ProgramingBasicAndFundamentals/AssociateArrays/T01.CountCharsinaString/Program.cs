using System;
using System.Collections.Generic;

namespace T01.CountCharsinaString
{
    internal class Program
    {
        public static object Dic { get; private set; }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (dic.ContainsKey(text[i]))
                {
                    dic[text[i]]++;
                }
                else
                {
                    dic.Add(text[i], 1);
                }
            }

            foreach (var keyValuePair in dic)
            {
                if (keyValuePair.Key != ' ')
                {
                    Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");

                }
            }
        }
    }
}
