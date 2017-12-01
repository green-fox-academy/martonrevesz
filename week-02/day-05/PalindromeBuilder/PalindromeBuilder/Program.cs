using System;

namespace PalindromeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "jhkjh5355";
            Console.WriteLine(ToPalindrome(input));
            Console.ReadLine();
        }

        static string ToPalindrome(string input)
        {
            char[] cArray = input.ToCharArray();
            string reverse = string.Empty;

            for (int i = 0; i < cArray.Length; i++)
            {
                reverse += cArray[cArray.Length - (i + 1)];
            }
            string palindrome = input + reverse;
            return palindrome;
        }
    }
}
