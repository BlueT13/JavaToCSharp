using System;

namespace Ex14
{
	internal class UsingOverride
	{
		public static void PrintUsingOverride()
		{
			Shape start, last, obj;
			obj = new Line(); start = obj; last = obj;
			obj = new Rect(); last.next = obj; last = obj;
			obj = new Line(); last.next = obj; last = obj;
			obj = new Circle(); last.next = obj; last = obj;

			Shape p = start;
			while (p != null)
			{
				p.Draw();
				p = p.next;
			}
		}
	}
}
