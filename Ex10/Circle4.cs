using System;

namespace Ex10
{
	internal class Circle4
	{
		int radius;

		public Circle4() { }

		public Circle4(int radius)
		{ 
			this.radius = radius; 
		}

		public void Set(int radius)
		{
			this.radius = radius;
		}

		public void PrintCircle4()
		{
			Circle4 ob1 = new Circle4(1);
			Circle4 ob2 = new Circle4(2);
			Circle4 s;

			s = ob2;
			ob1 = ob2;

			Console.WriteLine("ob1.radius = " + ob1.radius);
			Console.WriteLine("ob2.radius = " + ob2.radius);
		}
	}
}
