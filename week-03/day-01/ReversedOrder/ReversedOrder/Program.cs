using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path: ");
            //@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\reversed-order.txt"
            string path = @Console.ReadLine();            
            DecryptReversedOrder(path);
            Console.ReadLine();
        }

        static void DecryptReversedOrder(string path)
        {
            try
            {
                string[] array = File.ReadAllLines(path);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[array.Length - (i + 1)]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
