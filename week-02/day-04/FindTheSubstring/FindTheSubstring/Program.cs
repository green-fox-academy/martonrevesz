using System;

namespace FindTheSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheSubstring("student of the green fox academy", "fox"));
            Console.ReadLine();
        }

        static int FindTheSubstring(string container, string sub)
        {
            for (int i = 0; i < container.Length - (sub.Length - 1); i++)
            {
                if (container.Substring(i, sub.Length) == sub)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
