using System;

namespace T03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            inputText = inputText.Substring(inputText.LastIndexOf("\\") + 1);

            string fileName = inputText.Substring(0, inputText.LastIndexOf("."));
            string extention = inputText.Substring(inputText.LastIndexOf(".") + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
