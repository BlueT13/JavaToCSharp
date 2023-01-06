using System;

namespace Ex06
{
    internal class Ex06_5
    {
        public void PrintEx06_5()
        {
            for (int i = 2; i <= 9; i+=2)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for(int k = i; k <= i+1; k++)
                        Console.Write(k + " x " + j + " = " + k * j+"\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        
    }
}
