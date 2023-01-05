using System;

namespace Ex06
{
    internal class ForSample
    {
        public void PrintForSample()
        {
            int sum = 0;
            for(int i=1; i<=10;i++)
            {
                sum += i;
                Console.Write(i);
                if (i <= 9)
                    Console.Write("+");
                else
                    Console.Write("=" + sum);
            }
        }
    }
}
