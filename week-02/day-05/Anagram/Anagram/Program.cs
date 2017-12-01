using System;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "anagram ";
            string string2 = "gram anna";
            Console.WriteLine(IsAnagram(string1, string2));
            Console.ReadLine();
        }

        static Boolean IsAnagram(string s1, string s2)
        {
            string s1Copy = string.Copy(s1);
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

            for (int i = 0; i < s2.Length; i++)
            {
                if (!s2[i].Equals(' '))
                {
                    if (s1Copy.Contains(s2[i]))
                    {
                        s1Copy = s1Copy.Remove(s1Copy.IndexOf(s2[i]), 1);
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
