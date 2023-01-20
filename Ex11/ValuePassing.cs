using System;

namespace Ex11
{
	internal class ValuePassing
	{
		public static void PrintValue()
		{
			int n = 10;
			Increase(n);
			Console.WriteLine(n);
		}
		static void Increase(int m)
		{
			m = m + 1;
		}
	}
}
