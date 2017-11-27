using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array to store the 5 numbers
            double[] array = new double[5];

            //get and save the numbers
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Please enter the " + (i+1) + "th number: ");
                double.TryParse(Console.ReadLine(), out double result);
                array[i] = result;
            }

            //calculate and output the sum
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum of the 5 numbers is: " + sum);

            //calculate and output the average
            double average = sum /  (double) array.Length;
            Console.WriteLine("The average of the 5 numbers is: " + average);
            Console.ReadLine();
        }
    }
}
