using System;

namespace Ex12
{
	internal class CurrencyConverter
	{
		private static double rate;

		public static double ToDollar(double won)
		{
			return won/rate;
		}
		public static double ToKRW(double dollar)
		{
			return dollar * rate;
		}
		public static void SetRate(double r)
		{
			rate = r;
		}
	}
}
