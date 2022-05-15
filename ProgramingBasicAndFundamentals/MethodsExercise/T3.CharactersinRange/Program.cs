using System;
using System.Linq;

namespace T3.CharactersinRange
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    char startCh = char.Parse(Console.ReadLine());
        //    char endCh = char.Parse(Console.ReadLine());

        //    AllChar(startCh, endCh);
        //}

        //static void AllChar(char start, char end)
        //{
        //    for (char indexAscii = start; indexAscii < end; indexAscii++)
        //    {
        //        if (indexAscii == start)
        //        {

        //        }
        //        else
        //        {
        //            Console.Write($"{indexAscii} ");
        //        }
        //    }

        //    for (char indexAscii = end; indexAscii < start; indexAscii++)
        //    {
        //        if (indexAscii == end)
        //        {

        //        }
        //        else
        //        {
        //            Console.Write($"{indexAscii} ");
        //        }
        //    }
        //static void Main(string[] args)
        //{
        //    char[] ch = Console.ReadLine()
        //        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        //        .Select(char.Parse)
        //        .ToArray();
        //    int index = int.Parse(Console.ReadLine());
        //    int counter = 0;
        //    char[] exchangedArray = new char[ch.Length];

        //    for (int i = 0; i < ch.Length; i++)
        //    {
        //        if (ch.Length - 1 > index + i)
        //        {
        //            exchangedArray[i] = ch[index + i + 1];
        //        }
        //        else
        //        {
        //            exchangedArray[i] = ch[counter];
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(String.Join(" ", exchangedArray));
        //}

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //char[] ch = text
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(char.Parse)
            //    .ToArray();

            ExchangdIndex(text);
        }

        static void ExchangdIndex(string text)
        {
            int index = int.Parse(Console.ReadLine());
            int counter = 0;
            char[] ch = text
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] exchangedArray = new char[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch.Length - 1 > index + i)
                {
                    exchangedArray[i] = ch[index + i + 1];
                }
                else
                {
                    exchangedArray[i] = ch[counter];
                    counter++;
                }
            }
            Console.WriteLine(String.Join(" ", exchangedArray));
        }
    }
}
