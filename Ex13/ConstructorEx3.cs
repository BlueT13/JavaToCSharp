using System;

namespace Ex13
{
	partial class B : A
	{
		public B(int x)
		{
			Console.WriteLine("B-2");
		}
	}
	internal class ConstructorEx3
	{
		public static void PrintConstructorEx3()
		{
			B b = new B(5);
		}
	}
}
