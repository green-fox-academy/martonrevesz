using System;
using System.Linq;


namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            reversed = ReverseString(reversed);
            Console.WriteLine(reversed);
            Console.ReadLine();
        }

        static string ReverseString(string text)
        {
            char[] charArray = text.ToArray();
            string reversedString = String.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                reversedString = reversedString.Insert(reversedString.Length, charArray[charArray.Length - i - 1].ToString());
            }
            return reversedString;
        }
    }
}
