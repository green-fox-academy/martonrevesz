using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string sub1 = quote.Substring(1, 19);
            string sub2 = quote.Substring(21);

            //create stringbuilder and append elements to it
            var builder = new StringBuilder();
            builder.Append(sub1);
            builder.Append(" always takes longer than ");
            builder.Append(sub2);

            Console.WriteLine(builder.ToString());
            Console.ReadLine();
        }
    }
}
