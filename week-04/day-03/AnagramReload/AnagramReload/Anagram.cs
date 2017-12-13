using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramReload
{
    public class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            return IsFirstInSecond(s1, s2) && IsFirstInSecond(s2, s1);
        }

        public static bool IsFirstInSecond(string s1, string s2)
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
