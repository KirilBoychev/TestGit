using System;
using System.Collections.Generic;
using System.Linq;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            List<string> validDestinations = inputText
                .Split('/', '=', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> destinations = new List<string>();

            Console.WriteLine($"{String.Join(",", validDestinations)}");
            for (int i = 0; i < validDestinations.Count; i++)
            {
                char first = validDestinations[i][0];
                char last = validDestinations[i][validDestinations[i].Length - 1];

                if ((first == '=' && last == '=') || (first == '/' && last == '/'))
                {
                    validDestinations[i] = validDestinations[i].Remove(validDestinations[i].Length - 1, 1);
                    validDestinations[i] = validDestinations[i].Remove(0, 1);
                }

                int c1 = 0;
                int c2 = 0;
                for (int j = 0; j < validDestinations[i].Length; j++)
                {
                    if (validDestinations[i][j] == '=')
                    {
                        c1++;
                        char ch = validDestinations[i][j];
                        if (c1 % 2 == 0)
                        {
                            if (validDestinations[i][j] <= validDestinations[i].Length - 1)
                            {
                                validDestinations[i] = validDestinations[i].Substring(ch, validDestinations[i][j]);
                            }
                            else
                            {
                                validDestinations[i] = validDestinations[i].Substring(ch); 
                                break;
                            }
                            c1 = 0;
                        }
                    }
                    else if (validDestinations[i][j] == '/')
                    {
                        c2++;
                        char ch = validDestinations[i][j];
                        if (c2 % 2 == 0)
                        {
                            if (validDestinations[i][j] <= validDestinations[i].Length - 1)
                            {
                                validDestinations[i] = validDestinations[i].Substring(ch, validDestinations[i][j]);
                            }
                            else
                            {
                                validDestinations[i] = validDestinations[i].Substring(ch);
                                break;
                            }
                            c2 = 0;
                        }
                    }
                }
                Console.WriteLine(String.Join(',', validDestinations));
                if (validDestinations.Count <= 3)
                {
                    validDestinations.RemoveAt(i);
                    i--;
                    continue;
                }


                if (!char.IsUpper(validDestinations[i][0]))
                {
                    validDestinations.RemoveAt(i);
                    i--;
                    continue;
                }

                for (int j = 0; j < validDestinations[i].Length; j++)
                {
                    if (!char.IsLetter(validDestinations[i][j]))
                    {
                        validDestinations.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            int sum = 0;
            List<string> total = new List<string>();
            for (int i = 0; i < validDestinations.Count; i++)
            {
                if (validDestinations[i] != null)
                {
                    total.Add(validDestinations[i]);
                }
            }
            for (int i = 0; i < total.Count; i++)
            {
                sum += total[i].Length;
            }

            Console.WriteLine($"Destinations: {String.Join(", ", total)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
