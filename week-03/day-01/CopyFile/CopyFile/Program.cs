using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName1 = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file.txt";
            string fileName2 = @"C:\Users\Hajnal és Marci\greenfox\martonrevesz\week-03\day-01\my-file-copy.txt";
            CopyFile(fileName1, fileName2);
        }
        static bool CopyFile(string file1, string file2)
        {
            try
            {
                string[] array = File.ReadAllLines(file1);
                File.WriteAllLines(file2, array);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    } 
}
