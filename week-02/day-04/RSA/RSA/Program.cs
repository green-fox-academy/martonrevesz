using System;
using System.Numerics;
using System.Collections.Generic;



namespace RSAExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // p = 11 q = 23, p * q = 253, good exponent is 221= 13 * 17
            Console.WriteLine("Please enter a string to encrypt: ");
            char[] myChars = Console.ReadLine().ToCharArray();
            var unicodeNumbers = new List<int>();
            var encryptedNumbers = new List<int>();
            var resolvedNumbers = new List<int>();
            var finalCharacters = new List<char>();
            foreach (char item in myChars)
            {
                int number = Convert.ToInt16(item);
                unicodeNumbers.Add(number);
                BigInteger mybig = BigInteger.Pow(number, 17);
                int encrypted = (int)(mybig % 253);
                encryptedNumbers.Add(encrypted);
                mybig = BigInteger.Pow(encrypted, 13);
                int resolved = (int)(mybig % 253);
                resolvedNumbers.Add(resolved);
                finalCharacters.Add(Convert.ToChar(resolved));
            }
            Console.WriteLine("Printing unicode numbers");
            foreach (int item in unicodeNumbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Printing encrypted numbers");
            foreach (int item in encryptedNumbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Printing resolved numbers");
            foreach (int item in resolvedNumbers)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Printing final characters");
            foreach (char item in finalCharacters)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
