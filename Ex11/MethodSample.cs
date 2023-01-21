using System;

namespace Ex11
{
	public class MethodSample
	{
		public int GetSum(int i, int j) { return i + j; }
		public int GetSum(int i, int j, int k) { return i + j + k; }
		public double GetSum(double i, double j) { return i + j; }

		public static void PrintMethodSample()
		{
			MethodSample a = new MethodSample();
			Console.WriteLine(a.GetSum(1, 2));
			Console.WriteLine(a.GetSum(1, 2, 3));
			Console.WriteLine(a.GetSum(1.1, 2.2));
		}
	}
}
