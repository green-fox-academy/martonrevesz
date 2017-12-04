using System;
using System.IO;

namespace Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\Reversed\Reversed\reversed-lines.txt";
            DecryptReverse(path);
            Console.ReadLine();
        }
        static void DecryptReverse(string path)
        {
            var sw = new StreamWriter(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\Reversed\Reversed\reversed-lines-copy.txt");
            try
            {
                string[] myArray = File.ReadAllLines(path);
                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                        Console.Write(myArray[i][myArray[i].Length - (j + 1)]);
                        sw.Write(myArray[i][myArray[i].Length - (j + 1)]);
                    }
                    Console.Write("\n");
                    sw.Write("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
