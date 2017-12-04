using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                Console.WriteLine("Please enter the only valid filepath without quotes: ");
                //"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt"
                string path = @Console.ReadLine();
                if (!path.Equals(@"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt"))
                {
                    throw new MySpecialException();
                }
                Console.WriteLine("Please enter your name: ");
                string myName = Console.ReadLine();
                sw = new StreamWriter(path, true);
                sw.WriteLine(myName);
            }
            catch (MySpecialException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }

            }
            Console.ReadLine();
        }
    }
    class MySpecialException : Exception
    {
        public MySpecialException()
        {
            Console.WriteLine("Invalid file name!!!");
        }
    }
}
