using System;
using System.Text;

namespace T04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                char ch = Convert.ToChar(inputText[i] + 3);
                inputText = inputText.Replace(inputText[i], (char)(inputText[i] + 3));
            }

            Console.WriteLine(inputText);
        }
    }
}
