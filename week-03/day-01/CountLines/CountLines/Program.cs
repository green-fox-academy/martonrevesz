using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid file path: ");
            //my-file.txt
            string path = Console.ReadLine();
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
            catch(Exception e)
            {
                return 0;
            }
        }
    }
}
