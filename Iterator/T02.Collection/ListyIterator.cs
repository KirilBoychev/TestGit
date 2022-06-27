using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        List<T> list;
        int currIndex;

        public ListyIterator(params T[] data)
        {
            list = new List<T>(data);
            currIndex = 0;
        }
        public bool Move()
        {
            bool canMove = HasNext();
            if (canMove)
            {
                currIndex++;
            }
            return canMove;
        }
        public bool HasNext() => currIndex < list.Count - 1;
        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[currIndex]);
        }

        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.Write($"{item} "); ;
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
