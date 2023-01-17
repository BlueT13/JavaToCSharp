using System;

namespace Ex10
{
	internal class Circle2
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

		public Circle2() { }

		public Circle2(int r)
		{
			radius = r;
		}

		public void PrintCircle2()
		{
			Circle2 pizza = new Circle2(10);
			Console.WriteLine("Area: {0:N2}", pizza.GetArea());

			Circle2 donut = new Circle2();
			Console.WriteLine("Area: {0:N2}", donut.GetArea());
		}
	}
}
