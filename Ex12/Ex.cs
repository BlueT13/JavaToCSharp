using System;

namespace Ex12
{
	public  class Ex
	{
		public static void StaticSampleMain()
		{
			StaticSample.m = 10;
			Console.WriteLine(StaticSample.m);

			StaticSample.f();
			Console.WriteLine(StaticSample.m);

			StaticSample s1;
			s1 = new StaticSample();
			Console.WriteLine(StaticSample.m);
		}
	}
}
