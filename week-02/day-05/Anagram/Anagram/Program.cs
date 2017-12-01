using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "gerzson";
            string string2 = "ersznog";
            Console.WriteLine(IsAnagram(string1, string2));
            Console.ReadLine();
        }

        static Boolean IsAnagram(string s1, string s2)
        {
            return IsFirstInSecond(s1, s2) && IsFirstInSecond(s2, s1);
        }

        static Boolean IsFirstInSecond(string s1, string s2)
        {
            string s2Copy = string.Copy(s2);

            for (int i = 0; i < s1.Length; i++)
            {
                if (!s1[i].Equals(' '))
                {
                    if (s2Copy.Contains(s1[i]))
                    {
                        s2Copy = s2Copy.Remove(s2Copy.IndexOf(s1[i]), 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
