using System;

namespace Ex14_1
{
	class Shape
	{
		protected string name;

		public void Paint()
		{
			Draw();
		}

		public virtual void Draw()
		{
			Console.WriteLine("Shape");
		}
	}

	class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Circle");
		}
	}

	public class DynamicBinding
	{
		public static void DynamicBindingMainClass()
		{
			Shape b = new Circle();
			b.Paint();
		}
	}
}
