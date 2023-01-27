using System;

namespace Ex12
{
	public  class Ex
	{
		public static void StaticSampleMain()
		{
			StaticSample s1, s2;
			s1 = new StaticSample();
			s1.n = 5;
			s1.g();
			//오류
			//s1.m = 50;
			//Console.WriteLine(s1.m);
			s2 = new StaticSample();
			s2.n = 8;
			s2.h();
			//오류
			//s2.f();
			//Console.WriteLine(s2.m);
		}
	}
}
