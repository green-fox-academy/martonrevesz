using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduceYourself
{
	class Program
	{
		static void Main(string[] args)
		{
			// Write a program that prints a few details to the terminal window about you
			// It should print each detail to a new line.
			//  - Your name
			//  - Your age
			//  - Your height in meters (as a decimal fraction)
			//
			//  Example output:
			//  John Doe
			//  31
			//  1.87
			string myName = "Marci Revesz";
			int myAge = 25;
			double myHeight = 1.73;
			Console.WriteLine(myName);
			Console.WriteLine(myAge);
			Console.WriteLine(myHeight);
		}
	}
}
