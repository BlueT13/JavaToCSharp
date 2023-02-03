using System;

namespace Ex13
{
	partial class A
	{
		public A()
		{
			Console.WriteLine("A");
		}
	}
	partial class B : A
	{
		public B()
		{
			Console.WriteLine("B");
		}
	}

	partial class C : B
	{
		public C()
		{
			Console.WriteLine("C");
		}
	}

	internal class ConstructorEx
	{
		public static void PrintConstructorEx()
		{
			C c = new C();
		}
	}
}
