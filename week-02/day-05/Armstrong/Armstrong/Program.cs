using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string numberString = Console.ReadLine();
            bool result = IsArmstrong(numberString);
            if (result)
            {
                Console.WriteLine("The " + numberString + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine("The " + numberString + " is not an Armstrong number");
            }
            Console.ReadLine();
        }

        static bool IsArmstrong(string theString)
        {
            int number = 0;
            int sumOfPowers = 0;
            for (int i = 0; i < theString.Length; i++)
            {
                int digit = Int32.Parse(theString[i].ToString());
                sumOfPowers += Convert.ToInt32(Math.Pow((double)digit, theString.Length));
                number += digit * Convert.ToInt32(Math.Pow(10.0, (double)theString.Length - (i + 1)));
            }
            if (number == sumOfPowers)
            {
                return true;
            }
            return false;
        }
    }
}
