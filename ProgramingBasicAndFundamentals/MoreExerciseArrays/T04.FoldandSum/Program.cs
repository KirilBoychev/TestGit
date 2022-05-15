using System;
using System.Linq;

namespace T04.FoldandSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int counter2 = 0;

            int[] newArr = new int[inputArr.Length / 2];

            for (int ind = 0; ind < newArr.Length / 2; ind++)
            {
                newArr[ind] = inputArr[(inputArr.Length / 4)  + ind];
            }
            for (int ind = newArr.Length / 2; ind < newArr.Length; ind++)
            {
                newArr[ind] = inputArr[inputArr.Length / 2 + counter];
                counter++;
            }

            int[] newArrLeft = new int[inputArr.Length / 4];
            //LEFT ARRAY

            int[] newArrRight = new int[inputArr.Length / 4];
            //RIGHT ARRAY

            int[] leftOutput = new int[inputArr.Length / 4];
            int[] rightOutput = new int[inputArr.Length / 4];

            for (int index = 0; index <= (inputArr.Length - 1) / 4; index++)
            {
                newArrLeft[index] = inputArr[(inputArr.Length - 1) / 4 - index];
                leftOutput[index] = newArrLeft[index] + newArr[index];
            }
            Console.Write(String.Join(' ', leftOutput));

            //for (int i = ((inputArr.Length - 1) / 4) + 1; i <= (inputArr.Length - 1) / 2; i++)
            //{4 3 -1 2 5 0 1 9 8 6 7 -2
            //    newArrRight[newArrRight.Length - i] = inputArr[i];
            //}
            Console.Write(" ");
            for (int index = 0; index <= newArrRight.Length - 1; index++)
            {
                //Array.Reverse(inputArr, inputArr.Length * 3 / 4, inputArr.Length - 1);
                newArrRight[index] = inputArr[(inputArr.Length - 1) - counter2];
                rightOutput[index] = newArrRight[index] + newArr[newArr.Length / 2 + counter2];
                counter2++;
            }
            Console.Write(String.Join(' ', rightOutput));
            //for (int i = ((inputArr.Length - 1) / 2) + 1; i < ((inputArr.Length - 1) / 4) * 3; i++)
            //{
            //    sum = newArr[index] + newArr[i];
            //}
        }
    }
}
