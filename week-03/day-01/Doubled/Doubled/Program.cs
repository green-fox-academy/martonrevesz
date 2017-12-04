using System;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\Doubled\Doubled\duplicated-chars.txt";
            string path2 = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\Doubled\Doubled\duplicated-chars-copy.txt";
            DecryptDuplicated(path, path2);
            Console.ReadLine();
        }
        static void DecryptDuplicated(string path, string path2)
        {
            var sw = new StreamWriter(path2);
            try
            {
                string[] array = File.ReadAllLines(path);
                foreach (string line in array)
                {
                    char[] charArray = line.ToCharArray();
                    for (int i = 0; i < charArray.Length; i += 2)
                    {
                        Console.Write(charArray[i]);
                        sw.Write(charArray[i]);
                    }
                    Console.WriteLine("\n");
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
