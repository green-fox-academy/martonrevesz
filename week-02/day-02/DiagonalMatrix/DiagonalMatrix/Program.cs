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
            int[,] matrix = CreateDiagonalMatrix(16);
            PrintMatrix(matrix);
            Console.ReadLine();
		}

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        static int[,] CreateDiagonalMatrix(int n)
		{
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    if(i == j )
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }
	}
}
