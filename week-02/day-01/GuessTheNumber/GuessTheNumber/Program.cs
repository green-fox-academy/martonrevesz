using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			// Write a program that stores a number, and the user has to figure it out.
			// The user can input guesses, after each guess the program would tell one
			// of the following:
			//
			// The stored number is higher
			// The stried number is lower
			// You found the number: 8
			Random random = new Random();
			int number = random.Next(1, 1000);

			while(true)
			{
				Console.WriteLine("Please guess the number: ");
				int guess = int.Parse(Console.ReadLine());
				if(number == guess)
				{
					Console.WriteLine("Congrats! You found the number " + number);
					break;
				} 
				else if (number > guess)
				{
					Console.WriteLine("The stored number is higher");
				}
				else
				{
					Console.WriteLine("The stored number is lower");
				}
			}			
		}
	}
}
