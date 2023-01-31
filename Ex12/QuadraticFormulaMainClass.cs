using System;

namespace Ex12
{
	internal class QuadraticFormulaMainClass
	{
		public static void Answer()
		{
			double a, b, c;
			Console.WriteLine("2차 방정식 ax^2 + bx + c의 실수해 구하기");
			Console.Write("a값 입력: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("b값 입력: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.Write("c값 입력: ");
			c = Convert.ToDouble(Console.ReadLine());
			
			double[] x = QuadraticFormula.Calculate(a, b, c);
			QuadraticFormula.PrintAnswer(x);
		}
	}
}
