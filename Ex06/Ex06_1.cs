using System;

namespace Ex06
{
    internal class Ex06_1
    {
        public void PrintEx06_1()
        {
            int[] array = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87, 55, 60, 99, 63, 80 };
            int max = array[0];
            int min = array[0];
            int sum = 0;
            double sum2 = 0; 
            double m = 0, V = 0, sigma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                sum += array[i];
            }
            m = (double)sum / array.Length;
            
            for (int i = 0; i<array.Length; i++)
                sum2 += Math.Pow((array[i] - m), 2);
            
            V = sum2 / array.Length;
            sigma = Math.Sqrt(V);

            Console.WriteLine("max = "+max);
            Console.WriteLine("min = " + min);
            Console.WriteLine("m = " + m);
            Console.WriteLine("V = " + V);
            Console.WriteLine("sigma = " + sigma);
        }
    }
}
