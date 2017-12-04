using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] array = File.ReadAllLines(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt");
                foreach (string line in array)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
