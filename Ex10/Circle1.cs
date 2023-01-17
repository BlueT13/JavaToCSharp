using System;

namespace Ex10
{
	internal class Circle1
	{
		int radius;
		void Set(int r)
		{
			radius = r;
		}

		double GetArea()
		{
			return 3.14 * radius * radius;
		}

		public void PrintCircle1()
		{
			Circle1 pizza = new Circle1();
			pizza.Set(3);
			Console.WriteLine("Area: {0:N2}", pizza.GetArea());
		}
	}
}
