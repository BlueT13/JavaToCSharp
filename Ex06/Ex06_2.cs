using System;

namespace Ex06
{
    internal class Ex06_2
    {
        public void PrintEx06_2()
        {
            double p = 1000;
            double r = 0.05;
            int n = 10;
            double a = 0;

            Console.WriteLine("Year\t\tAmount on deposit");
            for(int i =1; i < n+1; i++)
            {
                a = p * Math.Pow((1 + r), i);
                Console.WriteLine("{0}\t\t{1}", i, a);
            }
        }
    }
}
