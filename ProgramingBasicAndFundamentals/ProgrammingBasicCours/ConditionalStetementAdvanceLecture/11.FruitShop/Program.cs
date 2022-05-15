using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Магазин за плодове през работните дни работи на следните цени:
            //плод   banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85
            //Събота и неделя магазинът работи на по - високи цени:
            //плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20
            //Напишете програма, която чете от конзолата плод(banana / apple / orange / grapefruit / kiwi / pineapple / grapes),
            //ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество(реално число) ,
            //въведени от потребителя, и пресмята цената според цените от таблиците по-горе.
            //Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или
            //невалидно име на плод да се отпечата "error".
            const double bananaWorkingDay = 2.5;
            const double appleWorkingDay = 1.2;
            const double orangeWorkingDay = 0.85;
            const double grapefruitWorkingDay = 1.45;
            const double kiwiWorkingDay = 2.7;
            const double pineappleWorkingDay = 5.5;
            const double grapesWorkingDay = 3.85;
            const double bananaWeekend = 2.7;
            const double appleWeekend = 1.25;
            const double orangeWeekend = 0.9;
            const double grapefruitWeekend = 1.6;
            const double kiwiWeekend = 3.0;
            const double pineappleWeekend = 5.6;
            const double grapesWeekend = 4.2;

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (fruit == "banana")
                    {
                        double result = bananaWorkingDay* quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        double result = appleWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        double result = orangeWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        double result = grapefruitWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit =="kiwi")
                    {
                        double result = kiwiWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        double result = pineappleWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        double result = grapesWorkingDay * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    if (fruit == "banana")
                    {
                        double result = bananaWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        double result = appleWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        double result = orangeWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        double result = grapefruitWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        double result = kiwiWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        double result = pineappleWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        double result = grapesWeekend * quantity;
                        Console.WriteLine($"{result:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
