using System;
using System.IO;

namespace Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\reversed-lines.txt";
            DecryptReverse(path);
            Console.ReadLine();
        }
        static void DecryptReverse(string path)
        {
            string[] myArray = File.ReadAllLines(path);
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][myArray[i].Length - (j + 1)]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
