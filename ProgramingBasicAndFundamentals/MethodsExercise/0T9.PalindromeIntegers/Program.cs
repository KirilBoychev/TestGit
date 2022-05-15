using System;

namespace _0T9.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palindrom = Console.ReadLine();

            while (palindrom != "END")
            {
                if (EndCommand(palindrom) == true)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

                palindrom = Console.ReadLine();
            }

            
        }

        static bool EndCommand(string palindrom)
        {
            bool flag = true;
            
                if (palindrom.Length % 2 == 0)
                {
                    for (int i = 0; i < palindrom.Length / 2; i++)
                    {
                        if (palindrom[i] == palindrom[(palindrom.Length - 1) - i])
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (palindrom.Length % 2 == 1)
                {
                    for (int i = 0; i < (palindrom.Length - 1) / 2; i++)
                    {
                        if (palindrom[i] == palindrom[(palindrom.Length - 1) - i])
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }

                if (flag == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
        }
    }
}
