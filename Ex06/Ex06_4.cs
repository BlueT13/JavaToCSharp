using System;

namespace Ex06
{
    internal class Ex06_4
    {
        public void PrintEx06_4()
        {
            for(int i = 2; i<=9; i++)
            {
                for(int j = 1; j<=9;j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                Console.WriteLine();
            }
        }
        
    }
}
