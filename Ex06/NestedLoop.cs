using System;

namespace Ex06
{
    internal class NestedLoop
    {
        public void PrintNestedLoop()
        {
            for(int i=1; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.Write("{0}*{1}={2} ", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
