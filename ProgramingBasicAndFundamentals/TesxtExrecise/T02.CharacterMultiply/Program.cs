using System;

namespace T02.CharacterMultiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string input1 = inputText.Substring(0, inputText.IndexOf(' '));
            string input2 = inputText.Substring(inputText.IndexOf(' ') + 1);

            int sum = 0;

            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                sum += input2[i] * input1[i];
            }


            for (int i = Math.Min(input1.Length, input2.Length); i < Math.Max(input1.Length, input2.Length); i++)
            {
                if (input1.Length > input2.Length)
                {
                    sum += input1[i];
                }
                else
                {
                    sum += input2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
