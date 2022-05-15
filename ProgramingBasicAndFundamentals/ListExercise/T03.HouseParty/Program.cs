using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            List<string> nameList = new List<string>(commandCount);
            //bool flag = true;

            for (int index = 0; index < commandCount; index++)
            {
                List<string> currentIndex = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                //nameList.Add("");

                if (currentIndex.Count == 3)
                {
                    if (!nameList.Contains(currentIndex[0]))
                    {
                        nameList.Add(currentIndex[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{currentIndex[0]} is already in the list!");
                    }
                }
                else if (currentIndex.Count == 4)
                {
                    if (!nameList.Contains(currentIndex[0]))
                    {
                        Console.WriteLine($"{currentIndex[0]} is not in the list!");
                    }
                    else
                    {
                        nameList.Remove(currentIndex[0]);
                    }
                }

                //if (index == 0)
                //{
                //    nameList[0] = currentIndex[0];
                //}

                //if (currentIndex.Count == 3)
                //{
                //    for (int ind2 = 0; ind2 < index; ind2++)
                //    {
                //        if (currentIndex[0] != nameList[ind2])
                //        {
                //            nameList[index] = currentIndex[0];
                //        }
                //        else
                //        {
                //            nameList.RemoveAt(index);
                //            index--;
                //            commandCount--;
                //            Console.WriteLine($"{currentIndex[0]} is already in the list!");
                //            break;
                //        }
                //    }
                //}
                //else if (currentIndex.Count == 4)
                //{
                //    for (int i = 0; i < index; i++)
                //    {
                //        if (currentIndex[0] == nameList[i])
                //        {
                //            flag = false;
                //            nameList.RemoveAt(index);
                //            nameList.RemoveAt(i);
                //            index -= 2;
                //            commandCount -= 2;
                //            break;
                //        }
                //        else
                //        {
                //            flag = true;
                //        }
                //    }
                //    if (flag == true)
                //    {
                //        Console.WriteLine($"{currentIndex[0]} is not in the list!");
                //    }
                //}
            }

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
        }
    }
}
