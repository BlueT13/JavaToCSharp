using System;

namespace Ex06
{
    internal class WhileSample
    {
        public void PrintWhileSample()
        {
            int sum = 0;
            int count = 0;

            Console.Write("Enter numbers (-1 deontes the end of input): ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != -1)
            {
                sum += n;
                count++;
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Count: {0}\nAverage: {1}", count, (double)sum / count);
        }
    }
}
