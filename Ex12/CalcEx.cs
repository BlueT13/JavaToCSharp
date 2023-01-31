using System;

namespace Ex12
{
	class Calc
	{
		public static int Abs(int a) { return a > 0 ? a : -a; }
		public static int Max(int a, int b) { return a > b ? a : b;}
		public static int Min(int a, int b) { return a < b ? a : b;}
	}
	internal class CalcEx
	{
		public static void PrintCalcEx()
		{
			Console.WriteLine(Calc.Abs(-5));
			Console.WriteLine(Calc.Max(10,8));
			Console.WriteLine(Calc.Min(-3,-8));
		}
	}
}
