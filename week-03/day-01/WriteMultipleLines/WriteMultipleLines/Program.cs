using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt";
            string myWord = "apple";
            int myNumber = 5;
            WriteMultipleLines(myPath, myWord, myNumber);
            
        }

        static void WriteMultipleLines(string path, string word, int number)
        {
            var sw = new StreamWriter(path, true);
            int counter = 0;

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
