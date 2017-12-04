using System;
using System.IO;

namespace EncodedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            BreakCaesar(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\encoded-lines.txt");
            Console.ReadLine();
        }

        static void BreakCaesar(string path)
        {
            string[] lines = null;
            int caesarNumber = 1;

            try
            {
                lines = File.ReadAllLines(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].Equals(' '))
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        int myChar = Convert.ToInt32(line[i]);
                        Console.Write(Convert.ToChar((myChar - caesarNumber)));
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
