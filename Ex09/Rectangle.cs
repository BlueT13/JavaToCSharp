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
			string input = Console.ReadLine();
			string[] str = input.Split(" ");
			int[] inputInts = new int[str.Length];
			for(int i = 0; i < str.Length; i++)
			{
				inputInts[i] = Convert.ToInt32(str[i]);
			}
			rect.width = inputInts[0];
			rect.height = inputInts[1];
			Console.WriteLine("Area: " + rect.GetArea());
		}
	}
}
