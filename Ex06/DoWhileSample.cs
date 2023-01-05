using System;

namespace Ex06
{
    internal class DoWhileSample
    {
        public void PrintDoWhileSample()
        {
            char a = 'a';
            do
            {
                Console.Write(a);
                a++;
            }
            while (a <= 'z');
        }
    }
}
