using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            //original order:  0 1 2 3 4 5 6 7
            //new order:       0 1 5 3 4 2 6 7
            string temp = list[2];
            list[2] = list[5];
            list[5] = temp;
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
