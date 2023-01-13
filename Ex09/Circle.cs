using System;

namespace Ex09
{
	internal class Circle
	{
		int radius;
		string name;

		public Circle() { }

		public double GetArea()
		{
			return 3.14 * radius * radius;
		}

		public void PrintCircle()
		{
			Circle pizza;
			pizza = new Circle();
			pizza.radius = 10;
			pizza.name = "CSharp-Pizza";
			double area = pizza.GetArea();
			Console.WriteLine("Area of {0}: {1:N1}", pizza.name, area);

			Circle donut = new Circle();
			donut.radius = 2;
			donut.name = "CSharp-Donut";
			area = donut.GetArea();
			Console.WriteLine("Area of {0}: {1:N2}", donut.name, area);
		}
	}
}
