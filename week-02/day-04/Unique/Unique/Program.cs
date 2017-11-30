using System;
using System.Collections.Generic;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() {1, 11, 34, 11, 52, 61, 1, 34 };
            Unique(list);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<int> Unique(List<int> list)
        {
            list.Sort();
            for (int i = 0; i < (list.Count -1 ); i++)
            {
                if (list[i] == list[i+1])
                {
                    list.Remove(list[i]);
                }
            }
            return list;
        }
    }
}
