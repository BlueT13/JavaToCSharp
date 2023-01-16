using System;

namespace Ex09
{
	internal class RandomIntegers
	{
		public void PrintRandomIntegers()
		{
			Random randomNumbers = new Random();
			int face;

			for (int count = 1; count <= 20; count++)
			{
				face = 1 + randomNumbers.Next(6);
				Console.Write("{0} ", face);
			}
		}
	}
}
