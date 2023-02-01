using System;

namespace Ex13
{
	class Point
	{
		private int x, y;
		
		public void Set(int x, int y)
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
		
		public void SetColor(string color)
		{
			this.color = color;
		}
		
		public void ShowColorPoint()
		{
			Console.Write(color);
			ShowPoint();
		}
	}

	class ColorPointEx
	{
		public static void Print()
		{
			Point p = new Point();
			p.Set(1, 2);
			p.ShowPoint();

			ColorPoint cp = new ColorPoint();
			cp.Set(3, 4);
			cp.SetColor("red");
			cp.ShowColorPoint();
		}
	}
}
