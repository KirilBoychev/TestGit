using System;
using System.Linq;

namespace T._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;

            while (command != "end")
            {
                command = Console.ReadLine();
                string[] commandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArr.Length == 2)
                {
                    if (commandArr[0] == "max" && commandArr[1] == "even")
                    {
                        MaxEvenIndex(input);
                    }
                    if (commandArr[0] == "max" && commandArr[1] == "odd")
                    {
                        MaxOddIndex(input);
                    }
                    if (commandArr[0] == "min" && commandArr[1] == "odd")
                    {
                        MinOddIndex(input);
                    }
                    if (commandArr[0] == "min" && commandArr[1] == "even")
                    {
                        MinEvenIndex(input);
                    }
                }

                if (commandArr.Length == 3)
                {
                    int digits = int.Parse(commandArr[1]);

                    if (commandArr[0] == "first" && commandArr[2] == "even")
                    {
                        FirstCountEven(input, digits);
                    }
                    if (commandArr[0] == "first" && commandArr[2] == "odd")
                    {
                        FirstCountOdd(input, digits);
                    }
                    if (commandArr[0] == "last" && commandArr[2] == "even")
                    {
                        LastCountEven(input, digits);
                    }
                    if (commandArr[0] == "last" && commandArr[2] == "odd")
                    {
                        LastCountOdd(input, digits);
                    }
                }

                if (commandArr.Length == 2)
                {
                    if (commandArr[0] == "exchange")
                    {
                        int index = int.Parse(commandArr[1]);
                        int counter = 0;
                        int[] exchangedArray = new int[input.Length];
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input.Length - 1 > index + i)
                            {
                                exchangedArray[i] = input[index + i + 1];
                            }
                            else
                            {
                                exchangedArray[i] = input[counter];
                                counter++;
                            }
                        }
                        if (index <= input.Length - 1)
                        {
                            input = exchangedArray;
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        //ExchangeIndex(input, command);
                    }
                }
            }

            if (command == "end")
            {
                Console.WriteLine($"[{string.Join(", ", input)}]");
            }
        }

        //static void ExchangeIndex(int[] input, string command)
        //{
        //    string[] commandArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    int index = int.Parse(commandArr[1]);
        //    int counter = 0;
        //    int[] exchangedArray = new int[input.Length];
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input.Length - 1 > index + i)
        //        {
        //            exchangedArray[i] = input[index + i + 1];
        //        }
        //        else
        //        {
        //            exchangedArray[i] = input[counter];
        //            counter++;
        //        }
        //    }
        //    if (index <= input.Length - 1)
        //    {
        //        Console.WriteLine(String.Join(" ", exchangedArray));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid index");
        //    }
        //}

        static void MaxEvenIndex(int[] input)
        {
            int maxIndexEven = -1;
            int valueOfMaxIndexEven = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (valueOfMaxIndexEven <= input[i])
                    {
                        valueOfMaxIndexEven = input[i];
                        maxIndexEven = i;
                    }
                }
            }

            if (maxIndexEven == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndexEven}");
            }
        }

        static void MaxOddIndex(int[] input)
        {
            int maxIndexOdd = -1;
            int valueOfMaxIndexOdd = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 1)
                {
                    if (valueOfMaxIndexOdd <= input[i])
                    {
                        valueOfMaxIndexOdd = input[i];
                        maxIndexOdd = i;
                    }
                }
            }

            if (maxIndexOdd == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{maxIndexOdd}");
            }
        }

        static void MinEvenIndex(int[] input)
        {
            int minIndexEven = -1;
            int valueOfMinIndexEven = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (valueOfMinIndexEven >= input[i])
                    {
                        valueOfMinIndexEven = input[i];
                        minIndexEven = i;
                    }
                }
            }

            if (minIndexEven == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{minIndexEven}");
            }
        }

        static void MinOddIndex(int[] input)
        {
            int minIndexOdd = -1;
            int valueOfMinIndexOdd = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 1)
                {
                    if (valueOfMinIndexOdd >= input[i])
                    {
                        valueOfMinIndexOdd = input[i];
                        minIndexOdd = i;
                    }
                }
            }

            if (minIndexOdd == -1)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{minIndexOdd}");
            }
        }

        static void FirstCountEven(int[] input, int digits)
        {
            if (digits <= input.Length)
            {
                int counter = 0;
                int[] arr = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        arr[counter] = input[i];
                        counter++;
                        if (counter == digits)
                        {
                            break;
                        }
                    }
                }

                if (arr.Length != 0)
                {
                    int[] arrNew = new int[counter];
                    for (int i = 0; i < arrNew.Length; i++)
                    {
                        arrNew[i] = arr[i];
                    }

                    Console.WriteLine($"[{String.Join(", ", arrNew)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        static void FirstCountOdd(int[] input, int digits)
        {
            if (digits <= input.Length)
            {
                int counter = 0;
                int[] arr = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 1)
                    {
                        arr[counter] = input[i];
                        counter++;
                        if (counter == digits)
                        {
                            break;
                        }
                    }
                }

                if (arr.Length != 0)
                {
                    int[] arrNew = new int[counter];
                    for (int i = 0; i < arrNew.Length; i++)
                    {
                        arrNew[i] = arr[i];
                    }

                    Console.WriteLine($"[{String.Join(", ", arrNew)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        static void LastCountEven(int[] input, int digits)
        {
            if (digits <= input.Length)
            {
                int counter = 0;
                int[] arr = new int[input.Length];

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 == 0)
                    {
                        arr[counter] = input[i];
                        counter++;
                        if (counter == digits)
                        {
                            break;
                        }
                    }
                }

                if (arr.Length != 0)
                {
                    int[] arrNew = new int[counter];
                    for (int i = 0; i < arrNew.Length; i++)
                    {
                        arrNew[i] = arr[i];
                    }

                    Array.Reverse(arr, arr.Length - 1, 0);
                    Console.WriteLine($"[{String.Join(", ", arrNew)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        static void LastCountOdd(int[] input, int digits)
        {
            if (digits <= input.Length)
            {
                int counter = 0;
                int[] arr = new int[input.Length];

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 == 1)
                    {
                        arr[counter] = input[i];
                        counter++;
                        if (counter == digits)
                        {
                            break;
                        }
                    }
                }

                if (arr.Length != 0)
                {
                    int[] arrNew = new int[counter];
                    for (int i = 0; i < arrNew.Length; i++)
                    {
                        arrNew[i] = arr[i];
                    }

                    Array.Reverse(arr, arr.Length - 1, 0);
                    Console.WriteLine($"[{String.Join(", ", arrNew)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
    }
}
