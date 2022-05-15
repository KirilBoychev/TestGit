using System;

namespace T05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //Странно, но повечето хора си плануват от рано почивката. Млад програмист разполага с определен бюджет и свободно време в даден сезон.
            //Напишете програма, която да приема на входа бюджета и сезона, а на изхода да изкарва, къде ще почива програмиста и колко ще похарчи.
            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи. Ако е лято ще почива на къмпинг, а зимата в хотел.
            //Ако е в Европа, независимо от сезона ще почива в хотел. Всеки къмпинг или хотел, според дестинацията,
            //има собствена цена която отговаря на даден процент от бюджета: 
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            //Вход
            //Входът се чете от конзолата и се състои от два реда, въведени от потребителя:
            //•	Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            //•	Втори ред –  Един от двата възможни сезона: „summer” или “winter”
            //Изход
            //На конзолата трябва да се отпечатат два реда.
            //•	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
            //•	Втори ред – “{ Вид почивка} – { Похарчена сума}“
            //o Почивката може да е между „Camp” и „Hotel”
            //o Сумата трябва да е закръглена с точност до вторият знак след запетаята.
            
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double hotelPrize = 0;
            string typeOfHotel = "";
            string destination = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe"; ;
            }

            if (destination == "Europe")
            {
                typeOfHotel = "Hotel";
            }
            else
            {
                switch (season)
                {
                    case "summer":
                        typeOfHotel = "Camp";
                        break;
                        case "winter":
                        typeOfHotel = "Hotel";
                            break;
                }
            }

            if (budget <= 100) //Bulgaria
            {
                switch (season)
                {
                    case "summer":
                        hotelPrize = 0.3 * budget;
                        break;
                    case "winter":
                        hotelPrize = 0.7 * budget;
                        break;
                }
            }
            else if (budget > 100 && budget <= 1000) // Balkans
            {
                switch (season)
                {
                    case "summer":
                        hotelPrize = 0.4 * budget;
                        break;
                    case "winter":
                        hotelPrize = 0.8 * budget;
                        break;
                }
            }
            else if (budget > 1000) //Europe
            {
                hotelPrize = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHotel} - {hotelPrize:f2}");
        }
    }
}
