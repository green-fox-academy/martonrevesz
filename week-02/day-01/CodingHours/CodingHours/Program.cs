using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            double spentHours = 6 * 17 * 5;
            Console.WriteLine("An avarage attendee codes " + spentHours + " during their education");
            double percentage = 30 / (double) 52 * 100;
            Console.WriteLine("An avarage attendee spends " + string.Format("{0:0.00}", percentage) + " percent of their work on coding");
        }
    }
}
