using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	class Program
	{
		static void Main(string[] args)
		{
			// Swap the values of the variables
			int a = 123;
			int b = 526;
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine("a: " + a + "  b: " + b);
			Console.ReadLine();
		}
	}
}
