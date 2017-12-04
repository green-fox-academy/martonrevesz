using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Please enter the only valid file path: ");
                //C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt
                string myPath = @Console.ReadLine();
                if (!myPath.Equals(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt"))
                {
                    throw new MyUglyException();
                }
                Console.WriteLine("Please enter an integer: ");
                int myNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a word: ");
                string myWord = Console.ReadLine();              
                WriteMultipleLines(myPath, myWord, myNumber);
                
            }
            catch (MyUglyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
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

    class MyUglyException : Exception
    {
        public MyUglyException()
        {
            Console.WriteLine("Hey, this is not the filepath that I expect");
        }
    }

}
