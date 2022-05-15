using System;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal espessoWithoutSugar = (decimal)(0.9 * 0.65);
            const decimal espessoNormal = (decimal)1.0;
            const decimal espessoWithSugar = (decimal)1.2;
            const decimal kapuchinoWithoutSugar = (decimal)(1.0 * 0.65);
            const decimal kapuchinoNormal = (decimal)1.2;
            const decimal kapuchinoWithSugar = (decimal)1.6;
            const decimal teaWithoutSugar = (decimal)(0.5 * 0.65);
            const decimal teaNormal = (decimal)0.6;
            const decimal teaWithSugar = (decimal)0.7;

            string text = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            decimal sum = 0;
            switch (text)
            {
                case "Espresso":
                    switch(sugar)
                    {
                        case "Without":
                            sum = espessoWithoutSugar * countDrinks;
                            break;
                        case "Normal":
                            sum = espessoNormal * countDrinks;
                            break;
                        case "Extra":
                            sum = espessoWithSugar * countDrinks;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            sum = kapuchinoWithoutSugar * countDrinks;
                            break;
                        case "Normal":
                            sum = kapuchinoNormal * countDrinks;
                            break;
                        case "Extra":
                            sum = kapuchinoWithSugar * countDrinks;
                            break;
                    }
                    break;
                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            sum = teaWithoutSugar * countDrinks;
                            break;
                        case "Normal":
                            sum = teaNormal * countDrinks;
                            break;
                        case "Extra":
                            sum = teaWithSugar * countDrinks;
                            break;
                    }
                    break;
            }

            if (text == "Espresso" && countDrinks > 4)
            {
                sum *= (decimal)0.75;
            }

            if (sum > 15)
            {
                sum *= (decimal)0.8;
            }
            Console.WriteLine($"You bought {countDrinks} cups of {text} for {sum:f2} lv.");
        }
    }
}
