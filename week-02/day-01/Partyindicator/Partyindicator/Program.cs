using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partyindicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of girls in the party");
            int girls = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of boys in the party");
            int boys = int.Parse(Console.ReadLine());

            if((girls == boys) && ((girls + boys )> 20))
            {
                Console.WriteLine("The party is excellent");
            }
            else if (girls == 0) {
                Console.WriteLine("Sausage party");

            } 
            else if (((girls + boys) > 20) && (boys != girls))
            {
                Console.WriteLine("Quite good party");
            }
            else
            {
                Console.WriteLine("Average party");
            }
        }
    }
}
