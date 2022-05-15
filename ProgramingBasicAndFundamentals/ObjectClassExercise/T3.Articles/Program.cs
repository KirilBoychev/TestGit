using System;
using System.Collections.Generic;
using System.Linq;

namespace T3.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<ListOfArticles> list = new List<ListOfArticles>();

            for (int index = 0; index < n; index++)
            {
                string[] currArr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string arrayIndex0 = currArr[0];
                string arrayIndex1 = currArr[1];
                string arrayIndex2 = currArr[2];

                ListOfArticles currIndex = new ListOfArticles(arrayIndex0, arrayIndex1, arrayIndex2);
                list.Add(currIndex);
            }

            string type = Console.ReadLine();

            if (type == "title")
            {
                list = list.OrderBy(t => t.Title).ToList();
            }
            else if (type == "content")
            {
                list = list.OrderBy(c => c.Content).ToList();
            }
            else if (type == "author")
            {
                list = list.OrderBy(c => c.Author).ToList();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class ListOfArticles
    {
        public ListOfArticles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
