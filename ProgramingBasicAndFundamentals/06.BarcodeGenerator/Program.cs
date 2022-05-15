using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            string text1 = minNum.ToString();
            char first = text1[text1.Length - 4];
            char second = text1[text1.Length - 3];
            char third = text1[text1.Length - 2];
            char forth = text1[text1.Length - 1];
            int first1 = Convert.ToInt32(new string(first, 1));
            int second1 = Convert.ToInt32(new string(second, 1));
            int third1 = Convert.ToInt32(new string(third, 1));
            int forth1 = Convert.ToInt32(new string(forth, 1));

            string text2 = maxNum.ToString();
            char first2 = text2[text2.Length - 4];
            char second2 = text2[text2.Length - 3];
            char third2 = text2[text2.Length - 2];
            char forth2 = text2[text2.Length - 1];
            int first3 = Convert.ToInt32(new string(first2, 1));
            int second3 = Convert.ToInt32(new string(second2, 1));
            int third3 = Convert.ToInt32(new string(third2, 1));
            int forth3 = Convert.ToInt32(new string(forth2, 1));


            
            for (int i = minNum; i < maxNum; i++)
            {
                for (int j = first1; j <= first3; j++)
                {
                   
                        for (int k = second1; k <= second3; k++)
                        {
                            
                                for (int l = third1; l <= third3; l++)
                                {
                                   
                                        for (int p = forth1; p <= forth3; p++)
                                        {
                                            if (j == first3 && k == second3 && l == third3 && p == forth3)
                                            {
                                                if ((j % 2 != 0) && (k % 2 != 0) && (l % 2 != 0) && (p % 2 != 0))
                                                {
                                                    Console.Write($"{j}{k}{l}{p} ");
                                                }
                                                Environment.Exit(0);
                                            }
                                            if ((j % 2 != 0) && (k % 2 != 0) && (l % 2 != 0) && (p % 2 != 0))
                                            {
                                                Console.Write($"{j}{k}{l}{p} ");
                                            }

                                        }
                                    
                                }
                            
                        }
                    
                }
            }
            
        }
    }
}
