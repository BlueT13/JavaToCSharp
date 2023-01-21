using System;

namespace Ex11
{
	internal class ReferencePassing
	{
		public static void PrintPizzaRadius()
		{
			Circle pizza = new Circle(10);
			Increase(pizza);
			Console.WriteLine(pizza.radius);
		}

		static void Increase(Circle m)
		{
			m.radius++;
		}
	}

	class Circle
	{
		public int radius;
		public Circle(int r)
		{
			radius = r;
		}
		double GetArea()
		{
			return 3.14 * radius * radius;
		}
	}
}
