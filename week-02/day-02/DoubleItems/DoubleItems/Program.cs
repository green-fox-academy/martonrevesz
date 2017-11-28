using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleItems
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] ag = new int[5];
			ag[0] = 3;
			ag[1] = 4;
			ag[2] = 5;
			ag[3] = 6;
			ag[4] = 7;
			//double the values in ag
			for (int i = 0; i < ag.Length; i++)
			{
			    ag[i] *= 2;
				Console.WriteLine(ag[i]);
			}
			Console.ReadLine();
		}
	}
}
