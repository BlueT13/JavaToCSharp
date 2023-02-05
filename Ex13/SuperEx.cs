using System;

namespace Ex13_1
{
	class Point
	{
		private int x, y;
		public Point()
		{
			this.x = this.y = 0;
		}
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public void ShowPoint()
		{
			Console.WriteLine("({0}, {1})", x, y);
		}
	}

	class ColorPoint : Point
	{
		private string color;
		public ColorPoint(int x, int y, string color) : base(x, y)
		{
			this.color = color;
		}
		public void ShowColorPoint()
		{
			Console.Write(color);
			ShowPoint();
		}
	}

	internal class SuperEx
	{
		public static void PrintSuperEx()
		{
			ColorPoint cp = new ColorPoint(5, 6, "blue");
			cp.ShowColorPoint();
		}
	}
}
