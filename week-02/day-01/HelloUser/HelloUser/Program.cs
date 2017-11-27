using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();
            Console.WriteLine("Your name is " + input);
            Console.ReadLine();

        }
    }
}
