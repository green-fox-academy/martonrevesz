using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            //create am string and call AppendA method on it
            string am = "kuty";
            Console.WriteLine(AppendA(am));
			Console.ReadLine();
        }

        //appends a to the input
        static string AppendA(string text)
        {
            return text + "a";
        }
    }
}
