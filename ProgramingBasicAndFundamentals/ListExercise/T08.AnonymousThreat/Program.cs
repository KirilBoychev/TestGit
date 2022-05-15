using System;
using System.Collections.Generic;
using System.Linq;

namespace T08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> commandList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (commandList[0] != "3:1" && commandList.Count != 1)
            {
                if (commandList[0] == "merge")
                {
                    int startIndex = int.Parse(commandList[1]);
                    int endIndex = int.Parse(commandList[2]);
                    if (startIndex >= 0 && endIndex < inputList.Count)
                    {
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList[startIndex] += inputList[i];
                            
                        }
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList.RemoveAt(i);
                            i--;
                            endIndex--;
                        }
                    }
                    else if (startIndex >= 0 && endIndex >= inputList.Count)
                    {
                        endIndex = inputList.Count - 1;
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList[startIndex] += inputList[i];

                        }
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList.RemoveAt(i);
                            i--;
                            endIndex--;
                        }
                    }
                    else if (startIndex < 0 && endIndex >= inputList.Count)
                    {
                        startIndex = 0;
                        endIndex = inputList.Count - 1;
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList[startIndex] += inputList[i];

                        }
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList.RemoveAt(i);
                            i--;
                            endIndex--;
                        }
                    }
                    else if (startIndex < 0 && endIndex < inputList.Count)
                    {
                        startIndex = 0;
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList[startIndex] += inputList[i];

                        }
                        for (int i = startIndex + 1; i <= endIndex; i++)
                        {
                            inputList.RemoveAt(i);
                            i--;
                            endIndex--;
                        }
                    }
                }
                else if (commandList[0] == "divide")
                {
                    int index = int.Parse(commandList[1]);
                    int partitation = int.Parse(commandList[2]);

                    string curr = inputList[index];
                    string @new = string.Empty;
                    for (int i = 0; i < partitation; i++)
                    {
                        int difference = inputList[index].Length % partitation;
                        int partLenght = inputList[index].Length / partitation;
                        for (int j = 0; j < partLenght; j++)
                        {
                            curr = inputList[index];
                            @new += curr[j];
                            curr.Remove(j);
                            j--;
                            partLenght--;
                        }
                        if (i == partitation - 1)
                        {
                            inputList.Insert(index + i, @new + difference);
                            inputList.RemoveAt(index + i + 1);
                        }
                        else
                        {
                            inputList.Insert(index + i, curr);
                            curr = string.Empty;
                        }
                    }


                    //    inputList.GetRange(index, partLenght);
                    //    Console.WriteLine(String.Join(' ', inputList));
                    //    //List<string> currString = inputList[index]
                    //    //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    //    //    .ToList();
                    //    //currString.GetRange()
                    //    //for (int index1 = 0; index1 < partitation; index1++)
                    //    //{
                    //    //    for (int i = 0; i < partLenght; i++)
                    //    //    {
                    //    //        inputList[index] = 
                    //    //    }
                    //    //}
                }

                commandList = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            Console.WriteLine(string.Join(' ', inputList));
        }

        static void Divide(string divide, int difference, int partLenght)
        {
            
        }
    }
}
