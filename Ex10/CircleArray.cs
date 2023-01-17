using System;

namespace Ex10
{
	class Circle5
	{
		int radius;
		public Circle5(int radius)
		{
			this.radius = radius;
		}
		
		public double GetArea()
		{
			return 3.14*radius*radius;
		}
	}

	internal class CircleArray
	{
		public void PrintCircleArray()
		{
			Circle5[] c;
			c = new Circle5[4];
			
			for(int i =0; i< c.Length; i++)
			{
				c[i] = new Circle5(i);
				Console.Write((int)c[i].GetArea()+" ");
			}
		}
	}
}
