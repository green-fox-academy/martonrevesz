using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
	class Program
	{
		static void Main(string[] args)
		{
            string[] myStringArray = { "hello", "green fox", "academy", "helloweekend" };
			Printer(myStringArray);
		}

		static void Printer(string[] array)
		{
			foreach (string item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
