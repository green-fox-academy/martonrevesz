using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] s = { 1, 2, 3, 4, 5, 6 };
			s[3] = 4;
			Console.WriteLine(s[3]);
		    Console.ReadLine();
		}
	}
}
