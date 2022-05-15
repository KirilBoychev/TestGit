using System;

namespace T01.SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestInteger(n1,n2,n3));
                
        }

        static int SmallestInteger(int n1, int n2, int n3)
        {
            int[] arr = new int[3] { n1, n2, n3 };
            int minNum = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= minNum)
                {
                    minNum = arr[i];
                }
            }
            return minNum;
        }
    }
}
