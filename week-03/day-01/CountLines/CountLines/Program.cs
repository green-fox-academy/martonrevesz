using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt";
            Console.WriteLine(CountLines(path));
            Console.ReadLine();
        }

        static int CountLines(string path)
        {
            try
            {
                int count = 0;
                var sb = new StreamReader(path);
                while (sb.ReadLine() != null)
                {
                    count++;
                }
                return count;
            }
            catch (FileNotFoundException e)
            {
                return 0;
            }
        }
    }
}
