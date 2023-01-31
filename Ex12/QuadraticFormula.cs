using System;
using System.Security.Cryptography.X509Certificates;

namespace Ex12
{
	public class QuadraticFormula
	{
		public static double[] Calculate(double a, double b, double c)
		{
			double[] x;
			if (Math.Pow(b, 2) - 4 * a * c < 0)
			{
				x = new double[0];
			}
			else if (Math.Pow(b, 2) - 4 * a * c == 0)
			{
				x = new double[1];
				x[0] = -b / (2 * a);
			}
			else
			{
				x = new double[2];
				x[0] = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
				x[1] = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
			}
			return x;
		}
		
		public static void PrintAnswer(double[] x)
		{
			if (x.Length == 0)
			{
				Console.WriteLine("no answer");
			}
			else
			{
				Console.Write("answer: ");
				for (int i = 0; i < x.Length; i++)
				{
					Console.Write(x[i]+" ");
				}
			}
		}
	}
}
