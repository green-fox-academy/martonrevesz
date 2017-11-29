using System;
using System.Collections.Generic;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list.Remove(2);
            list.Insert(1, "Croissant");
            list.Remove(false);
            list.Add("Ice cream");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}
