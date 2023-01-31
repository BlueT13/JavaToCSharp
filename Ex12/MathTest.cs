using System;

namespace Ex12
{
	internal class MathTest
	{
		public static void PrintMathTest()
		{
			Console.WriteLine("sqrt(900.0) = {0:N2}", Math.Sqrt(900.0));
			Console.WriteLine("cos(900.0) = {0:N2}", Math.Cos(900.0));
			Console.WriteLine("log(900.0) = {0:N2}", Math.Log(900.0));
			Console.WriteLine("floor(9.95) = {0:N2}", Math.Floor(9.95));
			Console.WriteLine("PI = " + Math.PI);
		}
	}
}
