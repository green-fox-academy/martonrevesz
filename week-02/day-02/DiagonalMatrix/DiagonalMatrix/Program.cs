using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintDiagonalMatrix(7);
			Console.ReadLine();
		}

		static void PrintDiagonalMatrix(int n)
		{
			//draw n lines
			for (int i = 0; i < n; i++)
			{
				//until we reach i we draw 0-s
				for (int j = 0; j < i; j++)
				{
					Console.Write("0 ");
				}

				//when we reach i we draw 0
				Console.Write("1 ");

				//after we leave i we draw 0-s
				for (int k = i + 1; k < n; k++)
				{
					Console.Write("0 ");
				}
				Console.Write("\n");
			}
		}
	}
}
