using System;
using System.Collections.Generic;

namespace MatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < Math.Max(girls.Count, boys.Count); i++)
            {
                if (girls.Count > i)
                {
                    order.Insert(order.Count, girls[i]);
                }
                if (boys.Count > i)
                {
                    order.Insert(order.Count, boys[i]);
                }
            }
            foreach (string item in order)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
