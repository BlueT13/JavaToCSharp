using System;

namespace Ex03
{
    internal class Ex03_3
    {
        public void PrintEx03_3()
        {
            double d = 0.1234;
            double e = 1234E-4; //소수점 좌측으로 4칸 이동 -> 0.1234
            double f = 0.1234f;
            double w = .1234D;

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(w);
        }
    }
}
