using System;
using System.Linq;

namespace T09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequence = int.Parse(Console.ReadLine());

            string[] arr = new string[lenghtOfSequence];

            int[] arrInt = new int[lenghtOfSequence];
            arrInt = Console.ReadLine()
                .Split('!', StringSplitOptions.TrimEntries)
                .Select(int.Parse)
                .ToArray();
            
            while (arr[0] != "Clone them")
            {
                for (int index = 0; index < arrInt.Length - 1; index++)
                {

                }
            }



            //string newString = Console.ReadLine();
            //string[] arr = new string[lenghtOfSequence];
            //arr = Console.ReadLine().Split('!');
            //string[] arrChar = new string[lenghtOfSequence];
            //arrChar = Console.ReadLine()
            //    .Split("!", StringSplitOptions.TrimEntries);
            //int counter = 1;
            //int maxCounter = 0;
            //int currentIndex = arrChar.Length - 1;
            //string[] searchArr = new string[lenghtOfSequence];
            //int sumOnes = 0;

            //while (arrChar[0] != "Clone them")
            //{
            //    for (int indexArr = 0; indexArr < arrChar.Length; indexArr++)
            //    {
            //        if (arrChar[indexArr] == "1")
            //        {
            //            if (arrChar[indexArr] == arrChar[indexArr + 1])
            //            {
            //                counter++;
            //            }
            //            else
            //            {
            //                if (counter > maxCounter)
            //                {
            //                    maxCounter = counter;
            //                    searchArr = arrChar;
            //                }
            //                else if (counter == maxCounter)
            //                {
            //                    if (indexArr < currentIndex)
            //                    {
            //                        currentIndex = indexArr + 1;
            //                        searchArr = arrChar;
            //                    }
            //                }
            //                else if (counter < maxCounter)
            //                {
            //                    sumOnes += counter;
            //                }
            //                sumOnes += counter;
            //            }
            //        }
            //        else
            //        {
            //            counter = 0;
            //        }
            //    }
            //    arrChar = Console.ReadLine()
            //    .Split("!", StringSplitOptions.TrimEntries);
            //}

            //if (arrChar[0] == "Clone them")
            //{
                
            //    Console.WriteLine($"Best DNA sample {currentIndex} with sum: {sumOnes}.");
            //    Console.WriteLine(String.Join(' ', searchArr));
            //}
            
        }
    }
}
