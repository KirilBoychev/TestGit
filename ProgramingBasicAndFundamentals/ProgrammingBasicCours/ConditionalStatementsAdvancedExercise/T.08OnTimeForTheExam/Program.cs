using System;

namespace T._08OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Студент трябва да отиде на изпит в определен час(например в 9:30 часа).
            //Той идва в изпитната зала в даден час на пристигане(например 9:40).
            //Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
            //Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е дошъл след часа на изпита, той е закъснял.
            //Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме,
            //дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.
            //Вход
            //От конзолата се четат 4 цели числа(по едно на ред), въведени от потребителя:
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            //Изход
            //На първият ред отпечатайте:
            //•	“Late”, ако студентът пристига по-късно от часа на изпита.
            //•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            //•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            //•	
            //“mm minutes after the start” за закъснение под час.
            //•	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.

            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            if (hourOfExam >=0 && hourOfExam < 24 && hourOfArrival >=0 && hourOfArrival < 24 && minuteOfExam >= 0 && minuteOfExam < 60 && minuteOfArrival >= 0 && minuteOfArrival < 60 )
            {
                int hourToMinutesExam = hourOfExam * 60;
                int hourToMinutesArrival = hourOfArrival * 60;
                int allExam = hourToMinutesExam + minuteOfExam;
                int allArrival = hourToMinutesArrival + minuteOfArrival;
                
                if (allArrival >= (allExam - 30) && allArrival <= allExam)
                {
                    Console.WriteLine("On time");
                }
                
                else if (allArrival < (allExam - 30))
                {
                    Console.WriteLine("Early");
                }

                else if (allArrival > allExam)
                {
                    Console.WriteLine("Late");
                }

                if (allArrival > allExam)
                {
                    int differenceAllMinutes = Math.Abs(allArrival - allExam);
                    int differenceHours = differenceAllMinutes / 60;
                    int differenceMinutes = differenceAllMinutes % 60;
                    

                    if (differenceAllMinutes > 0 && differenceAllMinutes < 60)
                    {
                        Console.WriteLine($"{differenceAllMinutes} minutes after the start");
                    }
                    
                    if (differenceAllMinutes >= 60)
                    {
                        
                        if (differenceMinutes < 10)
                        {
                            Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours after the start");
                        }
                        else
                        {
                            Console.WriteLine($"{differenceHours}:{differenceMinutes} hours after the start");
                        }
                    }
                }

                if (allArrival < allExam)
                {
                    int differenceAllMinutes = Math.Abs(allArrival - allExam);
                    int differenceHours = differenceAllMinutes / 60;
                    int differenceMinutes = differenceAllMinutes % 60;


                    if (differenceAllMinutes > 0 && differenceAllMinutes < 60)
                    {
                        Console.WriteLine($"{differenceAllMinutes} minutes before the start");
                    }

                    if (differenceAllMinutes >= 60)
                    {

                        if (differenceMinutes < 10)
                        {
                            Console.WriteLine($"{differenceHours}:{differenceMinutes:d2} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{differenceHours}:{differenceMinutes} hours before the start");
                        }
                    }
                }
            }

        }
    }
}
