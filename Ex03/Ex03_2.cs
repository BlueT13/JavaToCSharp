using System;

namespace Ex03
{
    internal class Ex03_2
    {
        public void PrintEx03_2()
        {
            int n = 15;
            int m = Convert.ToInt32("015", 8);
            int k = 0x15;   //16진수(hexadecimal)
            int b = 0b0101; //2진수(binary)
            long g = 24L;   //Long

            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(k);
            Console.WriteLine(b);
            Console.WriteLine(g);
        }
    }
}
