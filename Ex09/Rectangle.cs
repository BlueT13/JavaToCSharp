using System;

namespace Ex09
{
	internal class Rectangle
	{
		int width;
		int height;

		public int GetArea()
		{
			return width * height;
		}

		public void PrintRectangle()
		{
			Rectangle rect = new Rectangle();
			Console.Write(">> ");
			rect.width = Convert.ToInt32(Console.ReadLine());
			rect.height= Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Area: " + rect.GetArea());
		}
	}
}
