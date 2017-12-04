using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\duplicated-chars.txt";
            DecryptDuplicated(path);
            Console.ReadLine();
        }
        static void DecryptDuplicated(string path)
        {
            string[] array = File.ReadAllLines(path);
            foreach (string line in array)
            {
                char[] charArray = line.ToCharArray();
                for (int i = 0; i < charArray.Length; i += 2)
                {
                    Console.Write(charArray[i]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
