using System;

namespace Ex06
{
    internal class ArrayAccess
    {
        public void PrintArrayAccess()
        {
            int[] array = new int[5];
            int max = 0;

            Console.WriteLine("Enter 5 positive integers.");

            for(int i = 0;i< array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > max)
                    max = array[i];
            }
            Console.Write("Max: {0}", max);
        }
    }
}
