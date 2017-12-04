using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt";
            string myName = "Coffee";
            StreamWriter sw = new StreamWriter(path, true);
            try
            {
                sw.WriteLine(myName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
            }
            Console.ReadLine();
        }
    }
}
