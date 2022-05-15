using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product;

            Dictionary<string, decimal[]> dic = new Dictionary<string, decimal[]>();

            while ((product = Console.ReadLine()) != "buy")
            {
                string[] productArr = product
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string productType = productArr[0];
                decimal price = decimal.Parse(productArr[1]);
                decimal quantity = decimal.Parse(productArr[2]);

                decimal[] currOne = new decimal[2];
                currOne[0] = price;
                currOne[1] = quantity;

                if (dic.ContainsKey(productType))
                {
                    dic[productType][1] += quantity;
                    dic[productType][0] = price * dic[productType][1];
                }
                else
                {
                    currOne[0] = price * currOne[1];
                    dic.Add(productType, currOne);
                }
            }


            foreach (var producttt in dic)
            {
                Console.WriteLine($"{producttt.Key} -> {producttt.Value[0]:f2}");
            }
        }
    }
}
