using System;

namespace Ex10
{
	internal class Circle
	{
		int radius;
		string name;

		public Circle()
		{
			radius = 1; name = "";
		}

		private Circle(int r, string n)
		{
			radius = r; name = n;
		}

		private double GetArea()
		{
			return 3.14 * radius * radius;
		}

		public void PrintCircle()
		{
			Circle pizza = new Circle(10, "CSharp-pizza");
			double area = pizza.GetArea();
			Console.WriteLine("Area of " + pizza.name + ": " + area);

			Circle donut = new Circle();
			donut.name = "CSharp-donut";
			area = donut.GetArea();
			Console.WriteLine("Area of " + donut.name + ": " + area);
		}
	}
}
