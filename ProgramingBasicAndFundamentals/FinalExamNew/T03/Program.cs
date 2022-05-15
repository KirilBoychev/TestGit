using System;
using System.Collections.Generic;
using System.Linq;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Follower> list = new List<Follower>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] commandArr = command
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandName = commandArr[0];

                if (commandName == "New follower")
                {
                    string username = commandArr[1];
                    int like = 0;
                    int comment = 0;
                    Follower currOne = new Follower(username, like, comment);
                    if (!list.Any(x => x.Username == username))
                    {
                        list.Add(currOne);
                    }
                }
                else if (commandName == "Like")
                {
                    string username = commandArr[1];
                    int count = int.Parse(commandArr[2]);
                    if (!list.Any(x => x.Username == username))
                    {
                        int like = count;
                        int comment = 0;
                        Follower currOne = new Follower(username, like, comment);
                        list.Add(currOne);
                    }
                    else
                    {
                        foreach (var item in list.Where(x => x.Username == username).ToList())
                        {
                            item.Like += count;
                        }
                    }
                }
                else if (commandName == "Comment")
                {
                    string username = commandArr[1];
                    if (!list.Any(x => x.Username == username))
                    {
                        int like = 0;
                        int comment = 1;
                        Follower currOne = new Follower(username, like, comment);
                        list.Add(currOne);
                    }
                    else
                    {
                        foreach (var item in list.Where(x => x.Username == username).ToList())
                        {
                            item.Comment += 1;
                        }
                    }

                }
                else if (commandName == "Blocked")
                {
                    string username = commandArr[1];
                    //if (!list.Any(x => x.Username != username))
                    //{
                    //    Console.WriteLine($"{username} doesn't exist.");
                    //}
                    if (list.Any(x => x.Username == username))
                    {
                        foreach (var item in list.Where(x => x.Username == username).ToList())
                        {
                            list.Remove(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
            }

            Console.WriteLine($"{list.Count} followers");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Username}: {item.Like + item.Comment}");
            }
        }
    }

    class Follower
    {
        public Follower(string username, int like, int comment)
        {
            this.Username = username;
            this.Like = like;
            this.Comment = comment;
        }
        public string Username { get; set; }
        public int Like { get; set; }
        public int Comment { get; set; }
    }
}
