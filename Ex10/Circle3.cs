using System;

namespace Ex10
{
	internal class Circle3
	{
		int radius;

		public Circle3() { }

		public Circle3(int radius)
		{
			this.radius= radius;
		}

		public void Set(int radius)
		{ 
			this.radius= radius;
		}

		public double GetArea()
		{
			return 3.14 * radius * radius;
		}

		public void PrintCircle3()
		{
			Circle3 ob1 = new Circle3(1);
			Circle3 ob2 = new Circle3(2);
			Circle3 ob3 = new Circle3(3);
			Console.WriteLine("ob1: {0:N2}", ob1.GetArea());
			Console.WriteLine("ob2: {0:N2}", ob2.GetArea());
			Console.WriteLine("ob3: {0:N2}", ob3.GetArea());
			Console.WriteLine();

			ob1.Set(4);
			ob2.Set(5);
			ob3.Set(6);
			Console.WriteLine("ob1: {0:N2}", ob1.GetArea());
			Console.WriteLine("ob2: {0:N2}", ob2.GetArea());
			Console.WriteLine("ob3: {0:N2}", ob3.GetArea());
		}
	}
}
