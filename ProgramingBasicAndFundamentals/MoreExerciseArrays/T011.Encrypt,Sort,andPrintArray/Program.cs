﻿using System;
using System.Linq;

namespace T011.Encrypt_Sort_andPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
 
            string[] sequenceOfStrings = new string[arrLength];
 
            int[] valueOfString = new int[arrLength];
 
            for (int i = 0; i < sequenceOfStrings.Length; i++)
            {
                sequenceOfStrings[i] = Console.ReadLine();
 
                int sumVowels = 0;
                int sumCons = 0;
               
                foreach (char index in sequenceOfStrings[i])
                {
                    if (index == 'a' || index == 'e' || index == 'i' || index == 'o' || index == 'u'
                        || index == 'A' || index == 'E' || index == 'I' || index == 'O' || index == 'U')
                    {
                        sumVowels += ((int)index * sequenceOfStrings[i].Length);
                    }
                    else if (index >= 'a' && index <= 'z' || index >= 'A' && index <= 'Z')
                    {
                        sumCons += ((int)index / sequenceOfStrings[i].Length);
                    }
                }
                int stringSum = sumVowels + sumCons;
 
                valueOfString[i] = stringSum;
                
            }
            Array.Sort(valueOfString);
            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }
        }
    }
}
