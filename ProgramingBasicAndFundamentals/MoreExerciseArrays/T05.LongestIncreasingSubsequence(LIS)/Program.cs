using System;
using System.Linq;

namespace T05.LongestIncreasingSubsequence_LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxNum = int.MinValue;
            int[] arrTwoElements;
            for (int index = 0; index < inputArr.Length; index++)
            {
                if (inputArr[index] > maxNum)
                {

                }
            }   
                
        }
    }
}
