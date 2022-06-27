using System;
using System.Linq;

namespace T01.ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            ListyIterator<string> list = null;

            while ((command = Console.ReadLine()) != "END")
            {
                var com = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (com[0] == "Create")
                {
                    for (int i = 1; i < com.Length; i++)
                    {
                        list = new ListyIterator<string>(com.Skip(1).ToArray());
                    }
                }
                else if (com[0] == "Move")
                    Console.WriteLine(list.Move());
                else if (com[0] == "HasNext")
                    Console.WriteLine(list.HasNext());
                else if (com[0] == "Print")
                    list.Print();
            }
        }
    }
}
