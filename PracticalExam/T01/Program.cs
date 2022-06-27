using System;
using System.Collections.Generic;
using System.Linq;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>
                (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "Sink", 0 },
                { "Oven", 0 },
                { "Countertop", 0 },
                { "Wall", 0 },
                { "Floor", 0 },
            };

            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    int sum = whiteTiles.Peek() + greyTiles.Peek();
                    if (sum == 40)
                    {
                        dict["Sink"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 50)
                    {
                        dict["Oven"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 60)
                    {
                        dict["Countertop"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 70)
                    {
                        dict["Wall"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else
                    {
                        dict["Floor"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                }
                else
                {
                    int currWhite = whiteTiles.Pop() / 2;
                    whiteTiles.Push(currWhite);
                    int currGrey = greyTiles.Dequeue();
                    greyTiles.Enqueue(currGrey);
                }
            }

            if (whiteTiles.Count == 0)
            {
                Console.WriteLine($"White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }

            if (greyTiles.Count == 0)
            {
                Console.WriteLine($"Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }

            foreach (var item in dict.OrderByDescending(x =>x.Value).ThenBy(x => x.Key))
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
