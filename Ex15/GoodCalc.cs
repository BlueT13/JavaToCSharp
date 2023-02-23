using System;

namespace Ex15
{
	abstract class Calculator
	{
		public abstract int Add(int a, int b);
		public abstract int Subtract(int a, int b);
		public abstract double Average(int[] a);
	}

	internal class GoodCalc
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Subtract(int a, int b)
		{
			return a - b;
		}

		public double Average(int[] a)
		{
			double sum = 0;
			for (int i = 0; i < a.Length; i++)
			{
				sum += a[i];
			}
			return sum / a.Length;
		}

		public static void GoodCalc_MainMethod()
		{
			GoodCalc c = new GoodCalc();
			Console.WriteLine(c.Add(2, 3));
			Console.WriteLine(c.Subtract(2, 3));
			Console.WriteLine("{0:0.0}", c.Average(new int[] { 2, 3, 4 }));
		}
	}
}
