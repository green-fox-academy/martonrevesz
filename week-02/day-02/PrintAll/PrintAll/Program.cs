using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAll
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] af = { 4, 5, 6, 7 };
			PrintElements(af);
			Console.ReadLine();
		}

		static void PrintElements(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
		    }
		}
	}
}
