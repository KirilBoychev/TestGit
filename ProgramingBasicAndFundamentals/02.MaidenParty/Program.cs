using System;

namespace _02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            const double love = 0.6;
            const double rose = 7.2;
            const double keyHolder = 3.6;
            const double picture = 18.2;
            const double luckSurprise = 22.0;

            double partyPrize = double.Parse(Console.ReadLine());
            int loveCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int keyHolderCount = int.Parse(Console.ReadLine());
            int pictureCount = int.Parse(Console.ReadLine());
            int luckSurpriseCount = int.Parse(Console.ReadLine());

            double sum = 0;
            double hostingExpenses = 0;
            sum = love * loveCount + rose * roseCount + keyHolder * keyHolderCount + picture * pictureCount + luckSurprise * luckSurpriseCount;
            double total = 0;

            int articleCount = loveCount + roseCount + keyHolderCount + pictureCount + luckSurpriseCount;

            if (articleCount >= 25)
            {
                sum *= 0.65;
                total = sum * 0.9;
            }
            else
            {
                total = sum * 0.9;
            }

            double difference = Math.Abs(total - partyPrize);

            if (partyPrize >= total)
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
        }
    }
}
