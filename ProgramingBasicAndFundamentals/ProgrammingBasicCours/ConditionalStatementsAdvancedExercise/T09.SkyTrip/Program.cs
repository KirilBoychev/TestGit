using System;

namespace T09.SkyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
        //Атанас решава да прекара отпуската си в Банско и да кара ски.
        //Преди да отиде обаче, трябва да резервира хотел и да изчисли колко ще му струва престоя.
        //Налични са следните видове помещения, със следните цени за престой:
        //	"room for one person" – 18.00 лв за нощувка
        //	"apartment" – 25.00 лв за нощувка
        //	"president apartment" – 35.00 лв за нощувка
        //Според броят на дните, в които ще остане в хотела(пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере,
        //той може да ползва различно намаление.
        
        //След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive) или негативна(negative).
        //Ако оценката му е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25 % от нея.
        //Ако оценката му е негативна приспада от цената 10 %.
        //Вход
        //Входът се чете от конзолата и се състои от три реда:
        //•	Първи ред - дни за престой - цяло число в интервала[0...365]
        //•	Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
        //•	Трети ред - оценка - "positive"  или "negative"
        //Изход
        //На конзолата трябва да се отпечата един ред:
        //•	Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.

            const double roomForOnePerson = 18.0;
            const double apartment = 25.0;
            const double presidentApartment = 35.0;

            int daysInHotel = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nightInHotel = daysInHotel - 1;
            double expenses = 0;

            switch (typeOfRoom)
            {
                case "room for one person":
                    expenses = roomForOnePerson * nightInHotel;
                    break;
                case "apartment":
                    if (daysInHotel > 0 && daysInHotel < 10)
                    {
                        expenses = apartment * nightInHotel * 0.7;
                    }
                    else if (daysInHotel >=10 && daysInHotel <= 15)
                    {
                        expenses = apartment * nightInHotel * 0.65;
                    }
                    else if (daysInHotel > 15)
                    {
                        expenses = apartment * nightInHotel * 0.5;
                    }
                    break;
                case "president apartment":
                    if (daysInHotel > 0 && daysInHotel < 10)
                    {
                        expenses = presidentApartment * nightInHotel * 0.9;
                    }
                    else if (daysInHotel >= 10 && daysInHotel <= 15)
                    {
                        expenses = presidentApartment * nightInHotel * 0.85;
                    }
                    else if (daysInHotel > 15)
                    {
                        expenses = presidentApartment * nightInHotel * 0.8;
                    }
                    break;
            }

            switch (evaluation)
            {
                case "positive":
                    expenses *= 1.25;
                    break;
                case "negative":
                    expenses *= 0.9;
                    break;
            }

            Console.WriteLine($"{expenses:f2}");
        }
    }
}
