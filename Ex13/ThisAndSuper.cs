using System;

namespace Ex13_2
{
	class A
	{
		public A() : this(0)
		{
			Console.WriteLine("A");
		}
		public A(int x)
		{
			Console.WriteLine("A" + x);
		}
	}

	class B : A
	{
		public B() : this(0)
		{
			Console.WriteLine("B");
		}
		public B(int x) : base(x)
		{
			Console.WriteLine("B" + x);
		}
	}

	internal class ThisAndSuper
	{
		public static void PrintThisAndSuper()
		{
			B b = new B();
		}
	}
}
