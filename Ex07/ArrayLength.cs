using System;

namespace Ex07
{
    internal class ArrayLength
    {
        public void PrintArrayLength()
        {
            int sum = 0;
            double average = 0;

            Console.Write("Enter 5 integers >> ");
            string input = Console.ReadLine();
            string[] str = input.Split(" ");
            int[] integers = new int[5];
            for(int i = 0; i< integers.Length; i++)
            {
                integers[i] = int.Parse(str[i]);
                sum += integers[i];
            }
            average= (double)sum / integers.Length;
            Console.WriteLine("Average: "+ average);
        }
    }
}
