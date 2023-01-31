using System;

namespace Ex12
{
	internal class CurrencyConverterTest
	{
		public static void Converting()
		{
			Console.Write("Exchange rate ($1) >> ");
			double rate = Convert.ToDouble(Console.ReadLine());
			CurrencyConverter.SetRate(rate);

			Console.WriteLine("100,000 KRW = ${0:0,0.##}", CurrencyConverter.ToDollar(100_000));
			Console.WriteLine("$100 = {0:0,0} KRW", CurrencyConverter.ToKRW(100));
		}
	}
}
