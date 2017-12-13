using System;
using System.Collections.Generic;

namespace Extension
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public double Median(List<int> pool)
        {
            pool.Sort();
            if (pool.Count % 2 == 1)
            {
                return pool[pool.Count / 2];
            }
            return (pool[pool.Count / 2 - 1] + pool[pool.Count / 2]) / 2.0;
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i', 'á', 'é', 'í', 'ú', 'ü', 'ű', 'ó', 'ö', 'ő' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;

            for (int i = 0; i < length; i += 1)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = teve.Substring(0, i) + c + "v" + c + teve.Substring(i + 1);
                    length += 2;
                    i += 2;
                }
            }
            return teve;
        }
    }
}