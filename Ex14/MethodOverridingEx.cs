using System;

namespace Ex14
{
	class Shape
	{
		public Shape next;
		public Shape() { next = null; }

		// 메서드를 오버라이딩 할 때 부모 클래스에서는 virtual 로, 자식 클래스에서는 override 키워드로 메서드를 정의
		public virtual void Draw()
		{
			Console.WriteLine("Shape");
		}
	}

	class Line : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Line");
		}
	}

	class Rect : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Rect");
		}
	}

	class Circle : Shape
	{
		public override void Draw()
		{
			Console.WriteLine("Circle");
		}
	}

	internal class MethodOverridingEx
	{
		static void Paint(Shape p)
		{
			p.Draw();
		}
		public static void PrintMethodOverridingEx()
		{
			Line line = new Line();
			Paint(line);
			Paint(new Shape());
			Paint(new Line());
			Paint(new Rect());
			Paint(new Circle());
		}
	}
}
