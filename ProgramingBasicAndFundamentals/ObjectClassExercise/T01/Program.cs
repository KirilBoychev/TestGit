using System;
using System.Collections.Generic;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            List<TypeOfAdvertiseProduct> currString = new List<TypeOfAdvertiseProduct>();

            for (int i = 0; i < number; i++)
            {
                TypeOfAdvertiseProduct current = new TypeOfAdvertiseProduct(List<string> phrases, )
            }
        }
    }

    class TypeOfAdvertiseProduct
    {
        public TypeOfAdvertiseProduct(List<string> phrases, List<string> events, List<string> authors, List<string> cities)
        {
            phrases = new List<string>()
                {"Excellent product.", "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."};

            Random currRandom = new Random();
            int currIndex = 0;
            for (int i = 0; i < phrases.Count; i++)
            {
                currIndex = currRandom.Next(0, phrases.Count);

                string currText = phrases[currIndex];
                phrases[i] = phrases[currIndex];
                phrases[currIndex] = currText;
            }

            //for (int index = 0; index < words.Length; index++)
            //{
            //    currNum = randomNumGenerator.Next(0, words.Length);

            //    string word = words[index];
            //    words[index] = words[currNum];
            //    words[currNum] = word;
            //}
            
            Phrases = phrases;

            events = new List<string>() { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            Random currRandom1 = new Random();
            int currIndex1 = 0;
            for (int i = 0; i < phrases.Count; i++)
            {
                currIndex = currRandom1.Next(0, phrases.Count);

                string currText = phrases[currIndex1];
                phrases[i] = phrases[currIndex1];
                phrases[currIndex1] = currText;
            }
            Events = events;

            authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            Random currRandom2 = new Random();
            int currIndex2 = 0;
            for (int i = 0; i < phrases.Count; i++)
            {
                currIndex = currRandom2.Next(0, phrases.Count);

                string currText = phrases[currIndex2];
                phrases[i] = phrases[currIndex2];
                phrases[currIndex2] = currText;
            }
            Authors = authors;

            cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random currRandom3 = new Random();
            int currIndex3 = 0;
            for (int i = 0; i < phrases.Count; i++)
            {
                currIndex = currRandom3.Next(0, phrases.Count);

                string currText = phrases[currIndex3];
                phrases[i] = phrases[currIndex3];
                phrases[currIndex3] = currText;
            }
            Cities = cities;

            List<string> listNew = new List<string>();
            listNew.Add(this.Phrases[0]);
            listNew.Add(this.Events[0]);
            listNew.Add(this.Authors[0]);
            listNew.Add(this.Cities[0]);

        }
        public List<string> Phrases { get; set; }

        public List<string> Events { get; set; }

        public List<string> Authors { get; set; }

        public List<string> Cities { get; set; }

        public override string ToString()
        {
            return $"{this.Phrases[0]} {this.Events[0]} {this.Authors[0]} – {this.Cities[0]}.";
        }
    }
}
