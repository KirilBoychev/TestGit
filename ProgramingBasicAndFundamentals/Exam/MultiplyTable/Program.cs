using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int number = text.Length;
            number = 3;
            char num1 = text[text.Length - 1];
            char num2 = text[text.Length-2];
            char num3 = text[text.Length - 3];
            int num11 = Convert.ToInt32(new string(num1, 1));
            int num22 = Convert.ToInt32(new string(num2, 1));
            int num33 = Convert.ToInt32(new string(num3, 1));

            bool flag = false;

            
                for (int i = 1; i <= num11; i++)
                {
                    for (int l = 1; l <= num22; l++)
                    {
                        for (int j = 1; j <= num33; j++)
                        {
                            
                            int sum = i * l * j;
                            Console.WriteLine($"{i} * {l} * {j} = {sum}");
                            if (j == num33)
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (l == num22)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (i == num11)
                    {
                        flag = true;
                        break;
                    }
                }
             
        }
    }
}
