using System;

namespace Ex13
{
	partial class A
	{
		public A(int x)
		{
			Console.WriteLine("A-2");
		}
	}

	internal class ConstructorEx2
	{
		public static void PrintConstructorEx2()
		{
			B b = new B();
		}
	}
}
