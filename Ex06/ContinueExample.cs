using System;
using System.Diagnostics.CodeAnalysis;

namespace Ex06
{
    internal class ContinueExample
    {
        public void PrintContinueExample()
        {
            int sum = 0;

            Console.WriteLine("Enter 5 numbers.");
            for(int i =0; i < 5; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    continue;
                else
                    sum += n;
            }
            Console.WriteLine("Sum of positive numbers: " + sum);
        }
    }
}
