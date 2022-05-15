using System;

namespace T03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Марин и Нели си купуват къща не далеч от София.
            //Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва,
            //да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 
            //цвете Роза    Далия Лале    Нарцис Гладиола
            //Цена на брой в лева 5   3.80    2.80    3   2.50
            //Съществуват следните отстъпки:
            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            //От конзолата се четат 3 реда:
            //•	Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //•	Брой цветя -цяло число в интервала[10…1000]
            //•	Бюджет - цяло число в интервала[50…2500]
            //Да се отпечата на конзолата на един ред:
            //•	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //•	Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            //Сумата да бъде форматирана до втория знак след десетичната запетая.
            const double roses = 5.0;
            const double dahlias = 3.8;
            const double tulips = 2.8;
            const double nasrcissus = 3.0;
            const double gladiolus = 2.5;

            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            switch (typeOfFlowers)
            {
                case "Roses":
                    if (countOfFlowers > 80)
                    {
                        double result = roses * countOfFlowers * 0.9;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }
                        
                    }
                    else
                    {
                        double result = roses * countOfFlowers;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }

                    }
                    break;
                case "Dahlias":
                    if (countOfFlowers > 90)
                    {
                        double result = dahlias * countOfFlowers * 0.85;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }

                    }
                    else
                    {
                        double result = dahlias * countOfFlowers;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }

                    }
                    break;
                case "Tulips":
                    if (countOfFlowers > 80)
                    {
                        double result = tulips * countOfFlowers * 0.85;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }

                    }
                    else
                    {
                        double result = tulips * countOfFlowers;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }
                    }
                    break;
                case "Narcissus":
                    if (countOfFlowers < 120)
                    {
                        double result = nasrcissus * countOfFlowers * 1.15;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }
                    }
                    else
                    {
                        double result = nasrcissus * countOfFlowers;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }
                    }
                    break;
                case "Gladiolus":
                    if (countOfFlowers < 80)
                    {
                        double result = gladiolus * countOfFlowers * 1.20;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }

                    }
                    else
                    {
                        double result = gladiolus * countOfFlowers;
                        double difference = Math.Abs(result - budget);
                        if (budget >= result)
                        {
                            Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {difference:f2} leva left.");
                        }
                        else
                        {
                            Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
                        }
                    }
                    break;
            }
        }
    }
}
