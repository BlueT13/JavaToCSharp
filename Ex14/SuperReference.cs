using System;

namespace Ex14_2
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
			Console.WriteLine(name);
		}
	}

	class Circle : Shape
	{
		protected string name;
		public override void Draw()
		{
			name = "circle";
			base.name = "shape";
			base.Draw();
			Console.WriteLine(name);
		}
	}

	internal class SuperReference
	{
		public static void SuperReferenceMainMethod()
		{
			Shape b = new Circle();
			b.Paint();
		}
	}
}
