using System;
using System.Text;

namespace T01.ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            bool flag = false;

            while (inputText.Contains(", "))
            {
                string subText = inputText.Substring(0, inputText.IndexOf(","));
                flag = false;

                inputText = inputText.Substring(subText.Length + 2);

                if (subText.Length >= 3 && subText.Length <= 16)
                {
                    for (int i = 0; i < subText.Length; i++)
                    {
                        char ch = subText[i];
                        if (ch != '-' && ch != '_' && !char.IsLetterOrDigit(ch))
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                else
                {
                    flag = true;
                }
                if (flag == true)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(subText);
                }
            }

            flag = false;

            if (inputText.Length >= 3 && inputText.Length <= 16)
            {
                for (int i = 0; i < inputText.Length; i++)
                {
                    char ch = inputText[i];
                    if (ch != '-' && ch != '_' && !char.IsLetterOrDigit(ch))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            else
            {
                flag = true;
            }


            if (flag == false)
            {
                Console.WriteLine(inputText);
            }
        }
    }
}
