using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt";
            string word = "apple";
            int number = 5;
            int counter = 0;
            var sw = new StreamWriter(path, true);
            try
            {
                while (counter < number)
                {
                    sw.WriteLine(word);
                    counter++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Dispose();
            }
        }
    }
}
