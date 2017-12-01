using System;
using System.Collections.Generic;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "tot fade init google rar sooos palindrome";
            var resultList = new List<string>();
            resultList.AddRange(SearchPalindrome(test));
            foreach (string item in resultList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<string> SearchPalindrome(string input)
        {
            var list = new List<string>();
            if (input.Length < 2)
            {
                return list;
            }
            // i + 1 is the length of the substring examined
            for (int i = 2; i < input.Length; i++)
            {
                // j is the start index of the substring
                for (int j = 0; j < input.Length - i; j++)
                {
                    string sub = input.Substring(j, i + 1);
                    char[] subArray = sub.ToCharArray();
                    string reverse = string.Empty;

                    for (int k = 0; k < subArray.Length; k++)
                    {
                        reverse += subArray[subArray.Length - (k + 1)];
                    }
                    if (reverse.Equals(sub))
                    {
                        list.Add(sub);
                    }
                }
            }
            return list;
        }
    }
}
