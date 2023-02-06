﻿using System;

namespace Ex13_1
{
	class A
	{
		public A()
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
		public B()
		{
			Console.WriteLine("B");
		}
		public B(int x) : base(x)
		{
			Console.WriteLine("B" + x);
		}
	}
	internal class ConstructorEx4
	{
		public static void PrintConstructorEx4()
		{
			B b = new B(5);
		}
	}
}
