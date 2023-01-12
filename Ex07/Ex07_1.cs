using System;
using System.Runtime.CompilerServices;

namespace Ex07
{
	internal class Ex07_1
	{
		public void PrintEx07_1()
		{
			int[,] inputBits = { { 1, 0, 1, 0, 1, 1, 1, 1 },
								 { 1, 0, 0, 0, 0, 0, 1, 1 },
								 { 0, 1, 0, 0, 0, 0, 0, 0 },
								 { 1, 1, 1, 1, 0, 0, 0, 0 },
								 { 1, 0, 1, 1, 1, 0, 0, 1 },
								 { 0, 0, 0, 0, 0, 1, 1, 1 },
								 { 1, 1, 1, 1, 1, 1, 1, 1 },
								 { 0, 1, 1, 1, 1, 0, 0, 0 } };

			int[] colParity = new int[inputBits.GetLength(0)];
			for (int i = 0; i < inputBits.GetLength(0); i++)
			{
				int sum = 0;
				for (int j = 0; j < inputBits.GetLength(1); j++)
				{
					sum += inputBits[i, j];
				}
				EvenCheck(colParity, sum, i);
			}

			int[] rowParity = new int[inputBits.GetLength(1)];
			for (int j = 0; j < inputBits.GetLength(1); j++)
			{
				int sum = 0;
				for (int i = 0; i < inputBits.GetLength(0); i++)
				{
					sum += inputBits[i, j];
				}
				EvenCheck(rowParity, sum, j);
			}

			for (int i = 0; i < inputBits.GetLength(0); i++)
			{
				for (int j = 0; j < inputBits.GetLength(1); j++)
				{
					Console.Write("{0} ", inputBits[i, j]);
				}
				Console.Write(colParity[i]);
				Console.WriteLine();
			}

			int rowParitySum = 0;
			for (int i = 0; i < rowParity.Length; i++)
			{
				rowParitySum += rowParity[i];
				Console.Write("{0} ", rowParity[i]);
			}
			if (rowParitySum % 2 == 0)
			{
				Console.Write("0");
			}
			else
			{
				Console.Write("1");
			}
		}

		private int EvenCheck(int[] arr, int sum, int n)
		{
			if (sum % 2 == 0)
			{
				return arr[n] = 0;
			}
			else
			{
				return arr[n] = 1;
			}
		}
	}
}
